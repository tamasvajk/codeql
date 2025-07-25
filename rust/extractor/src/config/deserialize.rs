use serde::Deserializer;
use serde::de::Visitor;
use std::collections::HashMap;
use std::fmt::Formatter;
use std::hash::BuildHasher;
use std::marker::PhantomData;

// phantom data is required to allow parametrizing on `T` without actual `T` data
struct VectorVisitor<T: From<String>>(PhantomData<T>);
struct MapVisitor<S: BuildHasher + Default>(PhantomData<S>);

impl<'de, T: From<String>> Visitor<'de> for VectorVisitor<T> {
    type Value = Vec<T>;

    fn expecting(&self, formatter: &mut Formatter) -> std::fmt::Result {
        formatter.write_str("either a sequence, or a comma or newline separated string")
    }

    fn visit_str<E: serde::de::Error>(self, value: &str) -> Result<Vec<T>, E> {
        Ok(value
            .split(['\n', ','])
            .map(|s| T::from(s.to_owned()))
            .collect())
    }

    fn visit_seq<A>(self, mut seq: A) -> Result<Vec<T>, A::Error>
    where
        A: serde::de::SeqAccess<'de>,
    {
        let mut ret = Vec::new();
        while let Some(el) = seq.next_element::<String>()? {
            ret.push(T::from(el));
        }
        Ok(ret)
    }
}

impl<'de, S: BuildHasher + Default> Visitor<'de> for MapVisitor<S> {
    type Value = HashMap<String, Option<String>, S>;

    fn expecting(&self, formatter: &mut Formatter) -> std::fmt::Result {
        formatter.write_str(
            "either a sequence, or a comma or newline separated string of key[=value] entries",
        )
    }

    fn visit_str<E: serde::de::Error>(self, value: &str) -> Result<Self::Value, E> {
        Ok(value
            .split(['\n', ','])
            .map(|s| match s.split_once('=') {
                Some((key, value)) => (key.to_owned(), Some(value.to_owned())),
                None => (s.to_owned(), None),
            })
            .collect())
    }

    fn visit_seq<A>(self, mut seq: A) -> Result<Self::Value, A::Error>
    where
        A: serde::de::SeqAccess<'de>,
    {
        let mut ret = HashMap::with_hasher(Default::default());
        while let Some(el) = seq.next_element::<String>()? {
            match el.split_once('=') {
                None => {
                    ret.insert(el.to_owned(), None);
                }
                Some((key, value)) => {
                    ret.insert(key.to_owned(), Some(value.to_owned()));
                }
            }
        }
        Ok(ret)
    }
}

/// deserialize into a vector of `T` either of:
/// * a sequence of elements serializable into `String`s, or
/// * a single element serializable into `String`, then split on `,` and `\n`
pub(crate) fn deserialize_newline_or_comma_separated_vec<
    'a,
    D: Deserializer<'a>,
    T: From<String>,
>(
    deserializer: D,
) -> Result<Vec<T>, D::Error> {
    deserializer.deserialize_seq(VectorVisitor(PhantomData))
}

/// deserialize into a map of `String`s to `Option<String>`s either of:
/// * a sequence of elements serializable into `String`s, or
/// * a single element serializable into `String`, then split on `,` and `\n`
pub(crate) fn deserialize_newline_or_comma_separated_map<
    'a,
    D: Deserializer<'a>,
    S: BuildHasher + Default,
>(
    deserializer: D,
) -> Result<HashMap<String, Option<String>, S>, D::Error> {
    deserializer.deserialize_map(MapVisitor(PhantomData))
}
