// Tests for intraprocedural data flow.

fn source(i: i64) -> i64 {
    1000 + i
}
fn sink(s: i64) {
    println!("{}", s);
}

fn sink_ref(sr: &i64) {
    println!("{}", sr);
}

// -----------------------------------------------------------------------------
// Simple data flow through expressions and assignments

fn direct() {
    sink(source(1)); // $ hasValueFlow=1
}

fn variable_usage() {
    let s = source(2);
    sink(s); // $ hasValueFlow=2
}

fn if_expression(cond: bool) {
    let a = source(3);
    let b = 2;
    let c = if cond { a } else { b };
    sink(c); // $ hasValueFlow=3
}

fn match_expression(m: Option<i64>) {
    let a = source(4);
    let b = match m {
        Some(_) => a,
        None => 0,
    };
    sink(b); // $ hasValueFlow=4
}

fn loop_with_break() {
    let a = loop {
        break 1;
    };
    sink(a);
    let b = loop {
        break source(5);
    };
    sink(b); // $ hasValueFlow=5
}

fn assignment() {
    let mut i = 1;
    sink(i);
    i = source(6);
    sink(i); // $ hasValueFlow=6
}

fn block_expression1() -> i64 {
    let a = { 0 };
    a
}

fn block_expression2(b: bool) -> i64 {
    let a = 'block: {
        if b {
            break 'block 1;
        };
        2
    };
    a
}

fn block_expression3(b: bool) -> i64 {
    let a = 'block: {
        if b {
            break 'block 1;
        }
        break 'block 2;
    };
    a
}

// -----------------------------------------------------------------------------
// Data flow through `Box`

fn box_deref() {
    let i = Box::new(source(7));
    sink(*i); // $ hasValueFlow=7
}

// -----------------------------------------------------------------------------
// Data flow through tuples

fn tuple() {
    let a = (source(8), 2);
    sink(a.0); // $ hasValueFlow=8
    sink(a.1);
}

fn tuple_match() {
    let a = (2, source(38), 2);
    let (a0, a1, a2) = a;
    sink(a0);
    sink(a1); // $ hasValueFlow=38
    sink(a2);
}

fn tuple_mutation() {
    let mut a = (2, source(38));
    sink(a.0);
    sink(a.1); // $ hasValueFlow=38
    a.0 = source(70);
    a.1 = 2;
    sink(a.0); // $ hasValueFlow=70
    sink(a.1);
}

fn tuple_nested() {
    let a = (3, source(59));
    let b = (a, 3);
    sink(b.0 .0);
    sink(b.0 .1); // $ hasValueFlow=59
    sink(b.1);
}

// -----------------------------------------------------------------------------
// Data flow through structs

struct Point {
    x: i64,
    y: i64,
}

fn struct_field() {
    let p = Point { x: source(9), y: 2 };
    sink(p.x); // $ hasValueFlow=9
    sink(p.y);
}

fn struct_mutation() {
    let mut p = Point { x: source(9), y: 2 };
    sink(p.y);
    p.y = source(54);
    sink(p.y); // $ hasValueFlow=54
}

fn struct_pattern_match() {
    let p = Point {
        x: source(11),
        y: 2,
    };
    let Point { x: a, y: b } = p;
    sink(a); // $ hasValueFlow=11
    sink(b);
}

struct Point3D {
    plane: Point,
    z: i64,
}

fn struct_nested_field() {
    let p = Point3D {
        plane: Point {
            x: 2,
            y: source(77),
        },
        z: 4,
    };
    sink(p.plane.x);
    sink(p.plane.y); // $ hasValueFlow=77
    sink(p.z);
}

fn struct_nested_match() {
    let y = source(93);
    let p = Point3D {
        plane: Point { x: 2, y },
        z: 4,
    };
    match p {
        Point3D {
            plane: Point { x, y },
            z,
        } => {
            sink(x);
            sink(y); // $ hasValueFlow=93
            sink(z);
        }
    }
}

struct MyTupleStruct(i64, i64);

fn tuple_struct() {
    let s = MyTupleStruct(source(94), 2);
    sink(s.0); // $ hasValueFlow=94
    sink(s.1);

    match s {
        MyTupleStruct(x, y) => {
            sink(x); // $ hasValueFlow=94
            sink(y);
        }
    }
}

// -----------------------------------------------------------------------------
// Data flow through enums

fn option_pattern_match_qualified() {
    let s1 = Option::Some(source(13));
    let s2 = Option::Some(2);
    match s1 {
        Option::Some(n) => sink(n), // $ hasValueFlow=13
        Option::None => sink(0),
    }
    match s2 {
        Option::Some(n) => sink(n),
        Option::None => sink(0),
    }
}

fn option_pattern_match_unqualified() {
    let s1 = Some(source(14));
    let s2 = Some(2);
    match s1 {
        Some(n) => sink(n), // $ hasValueFlow=14
        None => sink(0),
    }
    match s2 {
        Some(n) => sink(n),
        None => sink(0),
    }
}

fn option_unwrap() {
    let s1 = Some(source(19));
    sink(s1.unwrap()); // $ hasValueFlow=19
}

fn option_unwrap_or() {
    let s1 = Some(source(46));
    sink(s1.unwrap_or(0)); // $ hasValueFlow=46

    let s2 = Some(0);
    sink(s2.unwrap_or(source(47))); // $ hasValueFlow=47
}

fn option_unwrap_or_else() {
    let s1 = Some(source(47));
    sink(s1.unwrap_or_else(|| 0)); // $ hasValueFlow=47

    let s2 = None;
    sink(s2.unwrap_or_else(|| source(48))); // $ hasValueFlow=48
}

fn option_questionmark() -> Option<i64> {
    let s1 = Some(source(20));
    let s2 = Some(2);
    let i1 = s1?;
    sink(i1); // $ hasValueFlow=20
    sink(s2?);
    Some(0)
}

fn option_ok() {
    let r1: Result<i64, i64> = Ok(source(21));
    let o1a: Option<i64> = r1.ok();
    let o1b: Option<i64> = r1.err();
    sink(o1a.unwrap()); // $ hasValueFlow=21
    sink(o1b.unwrap());

    let r2: Result<i64, i64> = Err(source(22));
    let o2a: Option<i64> = r2.ok();
    let o2b: Option<i64> = r2.err();
    sink(o2a.unwrap());
    sink(o2b.unwrap()); // $ hasValueFlow=22
}

fn result_questionmark() -> Result<i64, i64> {
    let s1: Result<i64, i64> = Ok(source(20));
    let s2: Result<i64, i64> = Ok(2);
    let s3: Result<i64, i64> = Err(source(77));
    let i1 = s1?;
    let i2 = s2?;
    sink(i1); // $ hasValueFlow=20
    sink(i2);
    let i3 = s3?;
    sink(i3); // No flow since value is in `Err`.
    Ok(0)
}

fn result_expect() {
    let s1: Result<i64, i64> = Ok(source(78));
    sink(s1.expect("")); // $ hasValueFlow=78
    sink(s1.expect_err(""));

    let s2: Result<i64, i64> = Err(source(79));
    sink(s2.expect(""));
    sink(s2.expect_err("")); // $ hasValueFlow=79
}

enum MyTupleEnum {
    A(i64),
    B(i64),
}

fn custom_tuple_enum_pattern_match_qualified() {
    let s1 = MyTupleEnum::A(source(15));
    let s2 = MyTupleEnum::B(2);
    match s1 {
        MyTupleEnum::A(n) => sink(n), // $ hasValueFlow=15
        MyTupleEnum::B(n) => sink(n),
    }
    match s1 {
        MyTupleEnum::A(n) | MyTupleEnum::B(n) => sink(n), // $ hasValueFlow=15
    }
    match s2 {
        MyTupleEnum::A(n) => sink(n),
        MyTupleEnum::B(n) => sink(n),
    }
}

use crate::MyTupleEnum::*;

fn custom_tuple_enum_pattern_match_unqualified() {
    let s1 = A(source(16));
    let s2 = B(2);
    match s1 {
        A(n) => sink(n), // $ hasValueFlow=16
        B(n) => sink(n),
    }
    match s1 {
        A(n) | B(n) => sink(n), // $ hasValueFlow=16
    }
    match s2 {
        A(n) => sink(n),
        B(n) => sink(n),
    }
}

enum MyRecordEnum {
    C { field_c: i64 },
    D { field_d: i64 },
}

fn custom_record_enum_pattern_match_qualified() {
    let s1 = MyRecordEnum::C {
        field_c: source(17),
    };
    let s2 = MyRecordEnum::D { field_d: 2 };
    match s1 {
        MyRecordEnum::C { field_c: n } => sink(n), // $ hasValueFlow=17
        MyRecordEnum::D { field_d: n } => sink(n),
    }
    match s1 {
        MyRecordEnum::C { field_c: n } | MyRecordEnum::D { field_d: n } => sink(n), // $ hasValueFlow=17
    }
    match s2 {
        MyRecordEnum::C { field_c: n } => sink(n),
        MyRecordEnum::D { field_d: n } => sink(n),
    }
}

use crate::MyRecordEnum::*;

fn custom_record_enum_pattern_match_unqualified() {
    let s1 = C {
        field_c: source(18),
    };
    let s2 = D { field_d: 2 };
    match s1 {
        C { field_c: n } => sink(n), // $ hasValueFlow=18
        D { field_d: n } => sink(n),
    }
    match s1 {
        C { field_c: n } | D { field_d: n } => sink(n), // $ hasValueFlow=18
    }
    match s2 {
        C { field_c: n } => sink(n),
        D { field_d: n } => sink(n),
    }
}

// -----------------------------------------------------------------------------
// Data flow through arrays

fn array_lookup() {
    let arr1 = [1, 2, source(94)];
    let n1 = arr1[2];
    sink(n1); // $ hasValueFlow=94

    let arr2 = [source(20); 10];
    let n2 = arr2[4];
    sink(n2); // $ hasValueFlow=20

    let arr3 = [1, 2, 3];
    let n3 = arr3[2];
    sink(n3);
}

fn array_for_loop() {
    let arr1 = [1, 2, source(43)];
    for n1 in arr1 {
        sink(n1); // $ hasValueFlow=43
    }

    let arr2 = [1, 2, 3];
    for n2 in arr2 {
        sink(n2);
    }
}

fn array_slice_pattern() {
    let arr1 = [1, 2, source(43)];
    match arr1 {
        [a, b, c] => {
            sink(a); // $ SPURIOUS: hasValueFlow=43
            sink(b); // $ SPURIOUS: hasValueFlow=43
            sink(c); // $ hasValueFlow=43
        }
    }
}

fn array_assignment() {
    let mut mut_arr = [1, 2, 3];
    sink(mut_arr[1]);

    mut_arr[1] = source(55);
    let d = mut_arr[1];
    sink(d); // $ hasValueFlow=55
    sink(mut_arr[0]); // $ SPURIOUS: hasValueFlow=55
}

// Test data flow inconsistency occuring with captured variables and `continue`
// in a loop.
pub fn captured_variable_and_continue(names: Vec<(bool, Option<String>)>) {
    let default_name = source(83).to_string();
    for (cond, name) in names {
        if cond {
            let n = name.unwrap_or_else(|| default_name.to_string());
            sink(n.len() as i64);
            continue;
        }
    }
}

macro_rules! get_source {
    ($e:expr) => {
        source($e)
    };
}

fn macro_invocation() {
    let s = get_source!(37);
    sink(s); // $ hasValueFlow=37
}

fn sink_string(s: String) {
    println!("{}", s);
}

fn parse() {
    let a = source(90);
    let b = a.to_string();
    let c = b.parse::<i64>().unwrap();
    let d: i64 = b.parse().unwrap();

    sink(a); // $ hasValueFlow=90
    sink_string(b); // $ MISSING: we are not currently able to resolve the `to_string` call above, which comes from `impl<T: fmt::Display + ?Sized> ToString for T`
    sink(c); // $ MISSING: hasTaintFlow=90 - we are not currently able to resolve the `parse` call above
    sink(d); // $ MISSING: hasTaintFlow=90 - we are not currently able to resolve the `parse` call above
}

fn iterators() {
    let vs = [source(91), 2, 3, 4];

    sink(vs[0]); // $ hasValueFlow=91
    sink(*vs.iter().next().unwrap()); // $ MISSING: hasValueFlow=91
    sink(*vs.iter().nth(0).unwrap()); // $ MISSING: hasValueFlow=91

    for v in vs {
        sink(v); // $ hasValueFlow=91
    }
    for &v in vs.iter() {
        sink(v); // $ MISSING: hasValueFlow=91
    }

    let vs2: Vec<&i64> = vs.iter().collect();
    for &v in vs2 {
        sink(v); // $ MISSING: hasValueFlow=91
    }

    vs.iter().map(|x| sink(*x)); // $ MISSING: hasValueFlow=91
    vs.iter().for_each(|x| sink(*x)); // $ MISSING: hasValueFlow=91

    for v in vs.into_iter() {
        sink(v); // $ MISSING: hasValueFlow=91
    }

    let mut vs_mut = [source(92), 2, 3, 4];

    sink(vs_mut[0]); // $ hasValueFlow=92
    sink(*vs_mut.iter().next().unwrap()); // $ MISSING: hasValueFlow=92
    sink(*vs_mut.iter().nth(0).unwrap()); // $ MISSING: hasValueFlow=92

    for &mut v in vs_mut.iter_mut() {
        sink(v); // $ MISSING: hasValueFlow=92
    }
}

fn references() {
    let a = source(40);
    let b = source(41);
    let c = source(42);
    let c_ref = &c;

    sink(a); // $ hasValueFlow=40
    sink_ref(&b); // $ hasTaintFlow=41
    sink_ref(c_ref); // $ hasTaintFlow=42
    sink(*c_ref); // $ hasValueFlow=42
}

fn conversions() {
    let a: i64 = source(50);

    sink(a as i64); // $ hasTaintFlow=50
    sink(a.into()); // $ MISSING: hasValueFlow=50
    sink(i64::from(a)); // $ hasTaintFlow=50

    let b: i32 = source(51) as i32;

    sink(b as i64); // $ hasTaintFlow=51
    sink(b.into()); // $ MISSING: hasTaintFlow=51
    sink(i64::from(b)); // $ hasTaintFlow=51
}

fn main() {
    direct();
    variable_usage();
    if_expression(true);
    match_expression(Some(0));
    loop_with_break();
    assignment();
    box_deref();
    tuple();
    tuple_match();
    tuple_mutation();
    tuple_nested();
    struct_field();
    tuple_struct();
    struct_mutation();
    struct_pattern_match();
    struct_nested_field();
    struct_nested_match();
    option_pattern_match_qualified();
    option_pattern_match_unqualified();
    option_unwrap();
    option_unwrap_or();
    option_questionmark();
    option_ok();
    let _ = result_questionmark();
    custom_tuple_enum_pattern_match_qualified();
    custom_tuple_enum_pattern_match_unqualified();
    custom_record_enum_pattern_match_qualified();
    custom_record_enum_pattern_match_unqualified();
    block_expression1();
    block_expression2(true);
    block_expression3(true);
    array_lookup();
    array_for_loop();
    array_slice_pattern();
    array_assignment();
    captured_variable_and_continue(vec![]);
    macro_invocation();
    parse();
    iterators();
    references();
    conversions();
}
