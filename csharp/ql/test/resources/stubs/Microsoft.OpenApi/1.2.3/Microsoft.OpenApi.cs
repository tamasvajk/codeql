// This file contains auto-generated code.

namespace Microsoft
{
    namespace OpenApi
    {
        // Generated from `Microsoft.OpenApi.JsonPointer` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
        public class JsonPointer
        {
            public JsonPointer(string pointer) => throw null;
            public Microsoft.OpenApi.JsonPointer ParentPointer { get => throw null; }
            public override string ToString() => throw null;
            public string[] Tokens { get => throw null; }
        }

        // Generated from `Microsoft.OpenApi.OpenApiFormat` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
        public enum OpenApiFormat
        {
            Json,
            // Stub generator skipped constructor 
            Yaml,
        }

        // Generated from `Microsoft.OpenApi.OpenApiSpecVersion` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
        public enum OpenApiSpecVersion
        {
            OpenApi2_0,
            OpenApi3_0,
            // Stub generator skipped constructor 
        }

        namespace Any
        {
            // Generated from `Microsoft.OpenApi.Any.AnyType` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum AnyType
            {
                // Stub generator skipped constructor 
                Array,
                Null,
                Object,
                Primitive,
            }

            // Generated from `Microsoft.OpenApi.Any.IOpenApiAny` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiAny : Microsoft.OpenApi.Interfaces.IOpenApiExtension, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                Microsoft.OpenApi.Any.AnyType AnyType { get; }
            }

            // Generated from `Microsoft.OpenApi.Any.IOpenApiPrimitive` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiPrimitive : Microsoft.OpenApi.Interfaces.IOpenApiExtension, Microsoft.OpenApi.Interfaces.IOpenApiElement, Microsoft.OpenApi.Any.IOpenApiAny
            {
                Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiArray` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiArray : System.Collections.Generic.List<Microsoft.OpenApi.Any.IOpenApiAny>, Microsoft.OpenApi.Interfaces.IOpenApiExtension, Microsoft.OpenApi.Interfaces.IOpenApiElement, Microsoft.OpenApi.Any.IOpenApiAny
            {
                public Microsoft.OpenApi.Any.AnyType AnyType { get => throw null; }
                public OpenApiArray() => throw null;
                public void Write(Microsoft.OpenApi.Writers.IOpenApiWriter writer, Microsoft.OpenApi.OpenApiSpecVersion specVersion) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiBinary` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiBinary : Microsoft.OpenApi.Any.OpenApiPrimitive<System.Byte[]>
            {
                public OpenApiBinary(System.Byte[] value) : base(default(System.Byte[])) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiBoolean` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiBoolean : Microsoft.OpenApi.Any.OpenApiPrimitive<bool>
            {
                public OpenApiBoolean(bool value) : base(default(bool)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiByte` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiByte : Microsoft.OpenApi.Any.OpenApiPrimitive<System.Byte[]>
            {
                public OpenApiByte(System.Byte[] value) : base(default(System.Byte[])) => throw null;
                public OpenApiByte(System.Byte value) : base(default(System.Byte[])) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiDate` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiDate : Microsoft.OpenApi.Any.OpenApiPrimitive<System.DateTime>
            {
                public OpenApiDate(System.DateTime value) : base(default(System.DateTime)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiDateTime` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiDateTime : Microsoft.OpenApi.Any.OpenApiPrimitive<System.DateTimeOffset>
            {
                public OpenApiDateTime(System.DateTimeOffset value) : base(default(System.DateTimeOffset)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiDouble` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiDouble : Microsoft.OpenApi.Any.OpenApiPrimitive<double>
            {
                public OpenApiDouble(double value) : base(default(double)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiFloat` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiFloat : Microsoft.OpenApi.Any.OpenApiPrimitive<float>
            {
                public OpenApiFloat(float value) : base(default(float)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiInteger` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiInteger : Microsoft.OpenApi.Any.OpenApiPrimitive<int>
            {
                public OpenApiInteger(int value) : base(default(int)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiLong` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiLong : Microsoft.OpenApi.Any.OpenApiPrimitive<System.Int64>
            {
                public OpenApiLong(System.Int64 value) : base(default(System.Int64)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiNull` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiNull : Microsoft.OpenApi.Interfaces.IOpenApiExtension, Microsoft.OpenApi.Interfaces.IOpenApiElement, Microsoft.OpenApi.Any.IOpenApiAny
            {
                public Microsoft.OpenApi.Any.AnyType AnyType { get => throw null; }
                public OpenApiNull() => throw null;
                public void Write(Microsoft.OpenApi.Writers.IOpenApiWriter writer, Microsoft.OpenApi.OpenApiSpecVersion specVersion) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiObject` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiObject : System.Collections.Generic.Dictionary<string, Microsoft.OpenApi.Any.IOpenApiAny>, Microsoft.OpenApi.Interfaces.IOpenApiExtension, Microsoft.OpenApi.Interfaces.IOpenApiElement, Microsoft.OpenApi.Any.IOpenApiAny
            {
                public Microsoft.OpenApi.Any.AnyType AnyType { get => throw null; }
                public OpenApiObject() => throw null;
                public void Write(Microsoft.OpenApi.Writers.IOpenApiWriter writer, Microsoft.OpenApi.OpenApiSpecVersion specVersion) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiPassword` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiPassword : Microsoft.OpenApi.Any.OpenApiPrimitive<string>
            {
                public OpenApiPassword(string value) : base(default(string)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiPrimitive<>` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public abstract class OpenApiPrimitive<T> : Microsoft.OpenApi.Interfaces.IOpenApiExtension, Microsoft.OpenApi.Interfaces.IOpenApiElement, Microsoft.OpenApi.Any.IOpenApiPrimitive, Microsoft.OpenApi.Any.IOpenApiAny
            {
                public Microsoft.OpenApi.Any.AnyType AnyType { get => throw null; }
                public OpenApiPrimitive(T value) => throw null;
                public abstract Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get; }
                public T Value { get => throw null; }
                public void Write(Microsoft.OpenApi.Writers.IOpenApiWriter writer, Microsoft.OpenApi.OpenApiSpecVersion specVersion) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Any.OpenApiString` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiString : Microsoft.OpenApi.Any.OpenApiPrimitive<string>
            {
                public bool IsExplicit() => throw null;
                public OpenApiString(string value, bool isExplicit) : base(default(string)) => throw null;
                public OpenApiString(string value) : base(default(string)) => throw null;
                public override Microsoft.OpenApi.Any.PrimitiveType PrimitiveType { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Any.PrimitiveType` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum PrimitiveType
            {
                Binary,
                Boolean,
                Byte,
                Date,
                DateTime,
                Double,
                Float,
                Integer,
                Long,
                Password,
                // Stub generator skipped constructor 
                String,
            }

        }
        namespace Exceptions
        {
            // Generated from `Microsoft.OpenApi.Exceptions.OpenApiException` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiException : System.Exception
            {
                public OpenApiException(string message, System.Exception innerException) => throw null;
                public OpenApiException(string message) => throw null;
                public OpenApiException() => throw null;
                public string Pointer { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Exceptions.OpenApiWriterException` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiWriterException : Microsoft.OpenApi.Exceptions.OpenApiException
            {
                public OpenApiWriterException(string message, System.Exception innerException) => throw null;
                public OpenApiWriterException(string message) => throw null;
                public OpenApiWriterException() => throw null;
            }

        }
        namespace Expressions
        {
            // Generated from `Microsoft.OpenApi.Expressions.BodyExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class BodyExpression : Microsoft.OpenApi.Expressions.SourceExpression
            {
                public const string Body = default;
                public BodyExpression(Microsoft.OpenApi.JsonPointer pointer) : base(default(string)) => throw null;
                public BodyExpression() : base(default(string)) => throw null;
                public override string Expression { get => throw null; }
                public string Fragment { get => throw null; }
                public const string PointerPrefix = default;
            }

            // Generated from `Microsoft.OpenApi.Expressions.CompositeExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class CompositeExpression : Microsoft.OpenApi.Expressions.RuntimeExpression
            {
                public CompositeExpression(string expression) => throw null;
                public System.Collections.Generic.List<Microsoft.OpenApi.Expressions.RuntimeExpression> ContainedExpressions;
                public override string Expression { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Expressions.HeaderExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class HeaderExpression : Microsoft.OpenApi.Expressions.SourceExpression
            {
                public override string Expression { get => throw null; }
                public const string Header = default;
                public HeaderExpression(string token) : base(default(string)) => throw null;
                public string Token { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Expressions.MethodExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class MethodExpression : Microsoft.OpenApi.Expressions.RuntimeExpression
            {
                public override string Expression { get => throw null; }
                public const string Method = default;
                public MethodExpression() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Expressions.PathExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class PathExpression : Microsoft.OpenApi.Expressions.SourceExpression
            {
                public override string Expression { get => throw null; }
                public string Name { get => throw null; }
                public const string Path = default;
                public PathExpression(string name) : base(default(string)) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Expressions.QueryExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class QueryExpression : Microsoft.OpenApi.Expressions.SourceExpression
            {
                public override string Expression { get => throw null; }
                public string Name { get => throw null; }
                public const string Query = default;
                public QueryExpression(string name) : base(default(string)) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Expressions.RequestExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class RequestExpression : Microsoft.OpenApi.Expressions.RuntimeExpression
            {
                public override string Expression { get => throw null; }
                public const string Request = default;
                public RequestExpression(Microsoft.OpenApi.Expressions.SourceExpression source) => throw null;
                public Microsoft.OpenApi.Expressions.SourceExpression Source { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Expressions.ResponseExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class ResponseExpression : Microsoft.OpenApi.Expressions.RuntimeExpression
            {
                public override string Expression { get => throw null; }
                public const string Response = default;
                public ResponseExpression(Microsoft.OpenApi.Expressions.SourceExpression source) => throw null;
                public Microsoft.OpenApi.Expressions.SourceExpression Source { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Expressions.RuntimeExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public abstract class RuntimeExpression : System.IEquatable<Microsoft.OpenApi.Expressions.RuntimeExpression>
            {
                public static Microsoft.OpenApi.Expressions.RuntimeExpression Build(string expression) => throw null;
                public override bool Equals(object obj) => throw null;
                public bool Equals(Microsoft.OpenApi.Expressions.RuntimeExpression obj) => throw null;
                public abstract string Expression { get; }
                public override int GetHashCode() => throw null;
                public const string Prefix = default;
                protected RuntimeExpression() => throw null;
                public override string ToString() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Expressions.SourceExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public abstract class SourceExpression : Microsoft.OpenApi.Expressions.RuntimeExpression
            {
                public static Microsoft.OpenApi.Expressions.SourceExpression Build(string expression) => throw null;
                protected SourceExpression(string value) => throw null;
                protected string Value { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Expressions.StatusCodeExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class StatusCodeExpression : Microsoft.OpenApi.Expressions.RuntimeExpression
            {
                public override string Expression { get => throw null; }
                public const string StatusCode = default;
                public StatusCodeExpression() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Expressions.UrlExpression` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class UrlExpression : Microsoft.OpenApi.Expressions.RuntimeExpression
            {
                public override string Expression { get => throw null; }
                public const string Url = default;
                public UrlExpression() => throw null;
            }

        }
        namespace Extensions
        {
            // Generated from `Microsoft.OpenApi.Extensions.EnumExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class EnumExtensions
            {
                public static T GetAttributeOfType<T>(this System.Enum enumValue) where T : System.Attribute => throw null;
                public static string GetDisplayName(this System.Enum enumValue) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Extensions.OpenApiElementExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class OpenApiElementExtensions
            {
                public static System.Collections.Generic.IEnumerable<Microsoft.OpenApi.Models.OpenApiError> Validate(this Microsoft.OpenApi.Interfaces.IOpenApiElement element, Microsoft.OpenApi.Validations.ValidationRuleSet ruleSet) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Extensions.OpenApiExtensibleExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class OpenApiExtensibleExtensions
            {
                public static void AddExtension<T>(this T element, string name, Microsoft.OpenApi.Interfaces.IOpenApiExtension any) where T : Microsoft.OpenApi.Interfaces.IOpenApiExtensible => throw null;
            }

            // Generated from `Microsoft.OpenApi.Extensions.OpenApiSerializableExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class OpenApiSerializableExtensions
            {
                public static void Serialize<T>(this T element, System.IO.Stream stream, Microsoft.OpenApi.OpenApiSpecVersion specVersion, Microsoft.OpenApi.OpenApiFormat format, Microsoft.OpenApi.Writers.OpenApiWriterSettings settings) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
                public static void Serialize<T>(this T element, System.IO.Stream stream, Microsoft.OpenApi.OpenApiSpecVersion specVersion, Microsoft.OpenApi.OpenApiFormat format) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
                public static void Serialize<T>(this T element, Microsoft.OpenApi.Writers.IOpenApiWriter writer, Microsoft.OpenApi.OpenApiSpecVersion specVersion) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
                public static string Serialize<T>(this T element, Microsoft.OpenApi.OpenApiSpecVersion specVersion, Microsoft.OpenApi.OpenApiFormat format) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
                public static void SerializeAsJson<T>(this T element, System.IO.Stream stream, Microsoft.OpenApi.OpenApiSpecVersion specVersion) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
                public static string SerializeAsJson<T>(this T element, Microsoft.OpenApi.OpenApiSpecVersion specVersion) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
                public static void SerializeAsYaml<T>(this T element, System.IO.Stream stream, Microsoft.OpenApi.OpenApiSpecVersion specVersion) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
                public static string SerializeAsYaml<T>(this T element, Microsoft.OpenApi.OpenApiSpecVersion specVersion) where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable => throw null;
            }

            // Generated from `Microsoft.OpenApi.Extensions.StringExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class StringExtensions
            {
                public static T GetEnumFromDisplayName<T>(this string displayName) => throw null;
            }

        }
        namespace Interfaces
        {
            // Generated from `Microsoft.OpenApi.Interfaces.IOpenApiElement` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiElement
            {
            }

            // Generated from `Microsoft.OpenApi.Interfaces.IOpenApiExtensible` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiExtensible : Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get; set; }
            }

            // Generated from `Microsoft.OpenApi.Interfaces.IOpenApiExtension` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiExtension
            {
                void Write(Microsoft.OpenApi.Writers.IOpenApiWriter writer, Microsoft.OpenApi.OpenApiSpecVersion specVersion);
            }

            // Generated from `Microsoft.OpenApi.Interfaces.IOpenApiReferenceable` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiReferenceable : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                Microsoft.OpenApi.Models.OpenApiReference Reference { get; set; }
                void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer);
                void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer);
                bool UnresolvedReference { get; set; }
            }

            // Generated from `Microsoft.OpenApi.Interfaces.IOpenApiSerializable` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiSerializable : Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer);
                void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer);
            }

        }
        namespace Models
        {
            // Generated from `Microsoft.OpenApi.Models.OpenApiCallback` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiCallback : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public void AddPathItem(Microsoft.OpenApi.Expressions.RuntimeExpression expression, Microsoft.OpenApi.Models.OpenApiPathItem pathItem) => throw null;
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiCallback() => throw null;
                public System.Collections.Generic.Dictionary<Microsoft.OpenApi.Expressions.RuntimeExpression, Microsoft.OpenApi.Models.OpenApiPathItem> PathItems { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiComponents` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiComponents : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiCallback> Callbacks { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiExample> Examples { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiHeader> Headers { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiLink> Links { get => throw null; set => throw null; }
                public OpenApiComponents() => throw null;
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiParameter> Parameters { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiRequestBody> RequestBodies { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiResponse> Responses { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiSchema> Schemas { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiSecurityScheme> SecuritySchemes { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiConstants` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class OpenApiConstants
            {
                public const string AccessCode = default;
                public const string AdditionalProperties = default;
                public const string AllOf = default;
                public const string AllowEmptyValue = default;
                public const string AllowReserved = default;
                public const string AnyOf = default;
                public const string Application = default;
                public const string Attribute = default;
                public const string AuthorizationCode = default;
                public const string AuthorizationUrl = default;
                public const string BasePath = default;
                public const string Basic = default;
                public const string BearerFormat = default;
                public const string BodyName = default;
                public const string Callbacks = default;
                public const string ClientCredentials = default;
                public const string Components = default;
                public const string Consumes = default;
                public const string Contact = default;
                public const string Content = default;
                public const string ContentType = default;
                public const string Default = default;
                public const string DefaultDefault = default;
                public const string DefaultDescription = default;
                public const string DefaultName = default;
                public const string DefaultTitle = default;
                public const string Definitions = default;
                public const string Delete = default;
                public const string Deprecated = default;
                public const string Description = default;
                public const string Discriminator = default;
                public const string DollarRef = default;
                public const string Email = default;
                public const string Encoding = default;
                public const string Enum = default;
                public const string Example = default;
                public const string Examples = default;
                public const string ExclusiveMaximum = default;
                public const string ExclusiveMinimum = default;
                public const string Explode = default;
                public const string ExtensionFieldNamePrefix = default;
                public const string ExternalDocs = default;
                public const string ExternalValue = default;
                public const string Flow = default;
                public const string Flows = default;
                public const string Format = default;
                public const string Get = default;
                public const string Head = default;
                public const string Headers = default;
                public const string Host = default;
                public const string Implicit = default;
                public const string In = default;
                public const string Info = default;
                public const string Items = default;
                public const string License = default;
                public const string Links = default;
                public const string Mapping = default;
                public const string MaxItems = default;
                public const string MaxLength = default;
                public const string MaxProperties = default;
                public const string Maximum = default;
                public const string MinItems = default;
                public const string MinLength = default;
                public const string MinProperties = default;
                public const string Minimum = default;
                public const string MultipleOf = default;
                public const string Name = default;
                public const string Namespace = default;
                public const string Not = default;
                public const string Nullable = default;
                public const string OneOf = default;
                public const string OpenApi = default;
                public const string OpenIdConnectUrl = default;
                public const string OperationId = default;
                public const string OperationRef = default;
                public const string Options = default;
                public const string Parameters = default;
                public const string Password = default;
                public const string Patch = default;
                public const string Paths = default;
                public const string Pattern = default;
                public const string Post = default;
                public const string Prefix = default;
                public const string Produces = default;
                public const string Properties = default;
                public const string PropertyName = default;
                public const string Put = default;
                public const string ReadOnly = default;
                public const string RefreshUrl = default;
                public const string RequestBodies = default;
                public const string RequestBody = default;
                public const string Required = default;
                public const string Responses = default;
                public const string Schema = default;
                public const string Schemas = default;
                public const string Scheme = default;
                public const string Schemes = default;
                public const string Scopes = default;
                public const string Security = default;
                public const string SecurityDefinitions = default;
                public const string SecuritySchemes = default;
                public const string Server = default;
                public const string Servers = default;
                public const string Style = default;
                public const string Summary = default;
                public const string Swagger = default;
                public const string Tags = default;
                public const string TermsOfService = default;
                public const string Title = default;
                public const string TokenUrl = default;
                public const string Trace = default;
                public const string Type = default;
                public const string UniqueItems = default;
                public const string Url = default;
                public const string Value = default;
                public const string Variables = default;
                public const string Version = default;
                public const string Wrapped = default;
                public const string WriteOnly = default;
                public const string Xml = default;
                public static System.Uri defaultUrl;
                public static System.Version version2_0;
                public static System.Version version3_0_0;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiContact` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiContact : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string Email { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public string Name { get => throw null; set => throw null; }
                public OpenApiContact() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Uri Url { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiDiscriminator` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiDiscriminator : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Collections.Generic.IDictionary<string, string> Mapping { get => throw null; set => throw null; }
                public OpenApiDiscriminator() => throw null;
                public string PropertyName { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiDocument` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiDocument : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public Microsoft.OpenApi.Models.OpenApiComponents Components { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiExternalDocs ExternalDocs { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiInfo Info { get => throw null; set => throw null; }
                public OpenApiDocument() => throw null;
                public Microsoft.OpenApi.Models.OpenApiPaths Paths { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Interfaces.IOpenApiReferenceable ResolveReference(Microsoft.OpenApi.Models.OpenApiReference reference) => throw null;
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiSecurityRequirement> SecurityRequirements { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiServer> Servers { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiTag> Tags { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiEncoding` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiEncoding : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public bool? AllowReserved { get => throw null; set => throw null; }
                public string ContentType { get => throw null; set => throw null; }
                public bool? Explode { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiHeader> Headers { get => throw null; set => throw null; }
                public OpenApiEncoding() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public Microsoft.OpenApi.Models.ParameterStyle? Style { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiError` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiError
            {
                public string Message { get => throw null; set => throw null; }
                public OpenApiError(string pointer, string message) => throw null;
                public OpenApiError(Microsoft.OpenApi.Exceptions.OpenApiException exception) => throw null;
                public string Pointer { get => throw null; set => throw null; }
                public override string ToString() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiExample` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiExample : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public string ExternalValue { get => throw null; set => throw null; }
                public OpenApiExample() => throw null;
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public string Summary { get => throw null; set => throw null; }
                public bool UnresolvedReference { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Any.IOpenApiAny Value { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiExtensibleDictionary<>` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public abstract class OpenApiExtensibleDictionary<T> : System.Collections.Generic.Dictionary<string, T>, Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement where T : Microsoft.OpenApi.Interfaces.IOpenApiSerializable
            {
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                protected OpenApiExtensibleDictionary() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiExternalDocs` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiExternalDocs : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiExternalDocs() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Uri Url { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiHeader` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiHeader : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public bool AllowEmptyValue { get => throw null; set => throw null; }
                public bool AllowReserved { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiMediaType> Content { get => throw null; set => throw null; }
                public bool Deprecated { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Any.IOpenApiAny Example { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiExample> Examples { get => throw null; set => throw null; }
                public bool Explode { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiHeader() => throw null;
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public bool Required { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiSchema Schema { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public Microsoft.OpenApi.Models.ParameterStyle? Style { get => throw null; set => throw null; }
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiInfo` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiInfo : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public Microsoft.OpenApi.Models.OpenApiContact Contact { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiLicense License { get => throw null; set => throw null; }
                public OpenApiInfo() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Uri TermsOfService { get => throw null; set => throw null; }
                public string Title { get => throw null; set => throw null; }
                public string Version { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiLicense` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiLicense : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public string Name { get => throw null; set => throw null; }
                public OpenApiLicense() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Uri Url { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiLink` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiLink : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiLink() => throw null;
                public string OperationId { get => throw null; set => throw null; }
                public string OperationRef { get => throw null; set => throw null; }
                public System.Collections.Generic.Dictionary<string, Microsoft.OpenApi.Models.RuntimeExpressionAnyWrapper> Parameters { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.RuntimeExpressionAnyWrapper RequestBody { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public Microsoft.OpenApi.Models.OpenApiServer Server { get => throw null; set => throw null; }
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiMediaType` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiMediaType : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiEncoding> Encoding { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Any.IOpenApiAny Example { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiExample> Examples { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiMediaType() => throw null;
                public Microsoft.OpenApi.Models.OpenApiSchema Schema { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiOAuthFlow` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiOAuthFlow : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Uri AuthorizationUrl { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiOAuthFlow() => throw null;
                public System.Uri RefreshUrl { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, string> Scopes { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Uri TokenUrl { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiOAuthFlows` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiOAuthFlows : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public Microsoft.OpenApi.Models.OpenApiOAuthFlow AuthorizationCode { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiOAuthFlow ClientCredentials { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiOAuthFlow Implicit { get => throw null; set => throw null; }
                public OpenApiOAuthFlows() => throw null;
                public Microsoft.OpenApi.Models.OpenApiOAuthFlow Password { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiOperation` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiOperation : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiCallback> Callbacks { get => throw null; set => throw null; }
                public bool Deprecated { get => throw null; set => throw null; }
                public const bool DeprecatedDefault = default;
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiExternalDocs ExternalDocs { get => throw null; set => throw null; }
                public OpenApiOperation() => throw null;
                public string OperationId { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiParameter> Parameters { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiRequestBody RequestBody { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiResponses Responses { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiSecurityRequirement> Security { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiServer> Servers { get => throw null; set => throw null; }
                public string Summary { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiTag> Tags { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiParameter` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiParameter : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public bool AllowEmptyValue { get => throw null; set => throw null; }
                public bool AllowReserved { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiMediaType> Content { get => throw null; set => throw null; }
                public bool Deprecated { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Any.IOpenApiAny Example { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiExample> Examples { get => throw null; set => throw null; }
                public bool Explode { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.ParameterLocation? In { get => throw null; set => throw null; }
                public string Name { get => throw null; set => throw null; }
                public OpenApiParameter() => throw null;
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public bool Required { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiSchema Schema { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public Microsoft.OpenApi.Models.ParameterStyle? Style { get => throw null; set => throw null; }
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiPathItem` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiPathItem : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public void AddOperation(Microsoft.OpenApi.Models.OperationType operationType, Microsoft.OpenApi.Models.OpenApiOperation operation) => throw null;
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiPathItem() => throw null;
                public System.Collections.Generic.IDictionary<Microsoft.OpenApi.Models.OperationType, Microsoft.OpenApi.Models.OpenApiOperation> Operations { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiParameter> Parameters { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiServer> Servers { get => throw null; set => throw null; }
                public string Summary { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiPaths` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiPaths : Microsoft.OpenApi.Models.OpenApiExtensibleDictionary<Microsoft.OpenApi.Models.OpenApiPathItem>
            {
                public OpenApiPaths() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiReference` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiReference : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string ExternalResource { get => throw null; set => throw null; }
                public string Id { get => throw null; set => throw null; }
                public bool IsExternal { get => throw null; }
                public bool IsLocal { get => throw null; }
                public OpenApiReference() => throw null;
                public string ReferenceV2 { get => throw null; }
                public string ReferenceV3 { get => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public Microsoft.OpenApi.Models.ReferenceType? Type { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiRequestBody` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiRequestBody : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiMediaType> Content { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiRequestBody() => throw null;
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public bool Required { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiResponse` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiResponse : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiMediaType> Content { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiHeader> Headers { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiLink> Links { get => throw null; set => throw null; }
                public OpenApiResponse() => throw null;
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiResponses` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiResponses : Microsoft.OpenApi.Models.OpenApiExtensibleDictionary<Microsoft.OpenApi.Models.OpenApiResponse>
            {
                public OpenApiResponses() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiSchema` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiSchema : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public Microsoft.OpenApi.Models.OpenApiSchema AdditionalProperties { get => throw null; set => throw null; }
                public bool AdditionalPropertiesAllowed { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiSchema> AllOf { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiSchema> AnyOf { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Any.IOpenApiAny Default { get => throw null; set => throw null; }
                public bool Deprecated { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiDiscriminator Discriminator { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Any.IOpenApiAny> Enum { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Any.IOpenApiAny Example { get => throw null; set => throw null; }
                public bool? ExclusiveMaximum { get => throw null; set => throw null; }
                public bool? ExclusiveMinimum { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiExternalDocs ExternalDocs { get => throw null; set => throw null; }
                public string Format { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiSchema Items { get => throw null; set => throw null; }
                public int? MaxItems { get => throw null; set => throw null; }
                public int? MaxLength { get => throw null; set => throw null; }
                public int? MaxProperties { get => throw null; set => throw null; }
                public System.Decimal? Maximum { get => throw null; set => throw null; }
                public int? MinItems { get => throw null; set => throw null; }
                public int? MinLength { get => throw null; set => throw null; }
                public int? MinProperties { get => throw null; set => throw null; }
                public System.Decimal? Minimum { get => throw null; set => throw null; }
                public System.Decimal? MultipleOf { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiSchema Not { get => throw null; set => throw null; }
                public bool Nullable { get => throw null; set => throw null; }
                public System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiSchema> OneOf { get => throw null; set => throw null; }
                public OpenApiSchema() => throw null;
                public string Pattern { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiSchema> Properties { get => throw null; set => throw null; }
                public bool ReadOnly { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public System.Collections.Generic.ISet<string> Required { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public string Title { get => throw null; set => throw null; }
                public string Type { get => throw null; set => throw null; }
                public bool? UniqueItems { get => throw null; set => throw null; }
                public bool UnresolvedReference { get => throw null; set => throw null; }
                public bool WriteOnly { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiXml Xml { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiSecurityRequirement` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiSecurityRequirement : System.Collections.Generic.Dictionary<Microsoft.OpenApi.Models.OpenApiSecurityScheme, System.Collections.Generic.IList<string>>, Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public OpenApiSecurityRequirement() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiSecurityScheme` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiSecurityScheme : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string BearerFormat { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiOAuthFlows Flows { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.ParameterLocation In { get => throw null; set => throw null; }
                public string Name { get => throw null; set => throw null; }
                public OpenApiSecurityScheme() => throw null;
                public System.Uri OpenIdConnectUrl { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public string Scheme { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public Microsoft.OpenApi.Models.SecuritySchemeType Type { get => throw null; set => throw null; }
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiServer` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiServer : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiServer() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public string Url { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiServerVariable> Variables { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiServerVariable` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiServerVariable : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string Default { get => throw null; set => throw null; }
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.List<string> Enum { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public OpenApiServerVariable() => throw null;
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiTag` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiTag : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiReferenceable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public string Description { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OpenApiExternalDocs ExternalDocs { get => throw null; set => throw null; }
                public string Name { get => throw null; set => throw null; }
                public OpenApiTag() => throw null;
                public Microsoft.OpenApi.Models.OpenApiReference Reference { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV2WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3WithoutReference(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public bool UnresolvedReference { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OpenApiXml` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiXml : Microsoft.OpenApi.Interfaces.IOpenApiSerializable, Microsoft.OpenApi.Interfaces.IOpenApiExtensible, Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public bool Attribute { get => throw null; set => throw null; }
                public System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> Extensions { get => throw null; set => throw null; }
                public string Name { get => throw null; set => throw null; }
                public System.Uri Namespace { get => throw null; set => throw null; }
                public OpenApiXml() => throw null;
                public string Prefix { get => throw null; set => throw null; }
                public void SerializeAsV2(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public void SerializeAsV3(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
                public bool Wrapped { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Models.OperationType` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum OperationType
            {
                Delete,
                Get,
                Head,
                // Stub generator skipped constructor 
                Options,
                Patch,
                Post,
                Put,
                Trace,
            }

            // Generated from `Microsoft.OpenApi.Models.ParameterLocation` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum ParameterLocation
            {
                Cookie,
                Header,
                // Stub generator skipped constructor 
                Path,
                Query,
            }

            // Generated from `Microsoft.OpenApi.Models.ParameterStyle` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum ParameterStyle
            {
                DeepObject,
                Form,
                Label,
                Matrix,
                // Stub generator skipped constructor 
                PipeDelimited,
                Simple,
                SpaceDelimited,
            }

            // Generated from `Microsoft.OpenApi.Models.ReferenceType` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum ReferenceType
            {
                Callback,
                Example,
                Header,
                Link,
                Parameter,
                // Stub generator skipped constructor 
                RequestBody,
                Response,
                Schema,
                SecurityScheme,
                Tag,
            }

            // Generated from `Microsoft.OpenApi.Models.RuntimeExpressionAnyWrapper` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class RuntimeExpressionAnyWrapper : Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public Microsoft.OpenApi.Any.IOpenApiAny Any { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Expressions.RuntimeExpression Expression { get => throw null; set => throw null; }
                public RuntimeExpressionAnyWrapper() => throw null;
                public void WriteValue(Microsoft.OpenApi.Writers.IOpenApiWriter writer) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Models.SecuritySchemeType` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum SecuritySchemeType
            {
                ApiKey,
                Http,
                OAuth2,
                OpenIdConnect,
                // Stub generator skipped constructor 
            }

        }
        namespace Services
        {
            // Generated from `Microsoft.OpenApi.Services.CurrentKeys` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class CurrentKeys
            {
                public string Callback { get => throw null; set => throw null; }
                public string Content { get => throw null; set => throw null; }
                public CurrentKeys() => throw null;
                public string Encoding { get => throw null; set => throw null; }
                public string Example { get => throw null; set => throw null; }
                public string Extension { get => throw null; set => throw null; }
                public string Header { get => throw null; set => throw null; }
                public string Link { get => throw null; set => throw null; }
                public Microsoft.OpenApi.Models.OperationType? Operation { get => throw null; set => throw null; }
                public string Path { get => throw null; set => throw null; }
                public string Response { get => throw null; set => throw null; }
                public string ServerVariable { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Services.OpenApiVisitorBase` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public abstract class OpenApiVisitorBase
            {
                public Microsoft.OpenApi.Services.CurrentKeys CurrentKeys { get => throw null; }
                public void Enter(string segment) => throw null;
                public void Exit() => throw null;
                protected OpenApiVisitorBase() => throw null;
                public string PathString { get => throw null; }
                public virtual void Visit(System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiTag> openApiTags) => throw null;
                public virtual void Visit(System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiServer> servers) => throw null;
                public virtual void Visit(System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiSecurityRequirement> openApiSecurityRequirements) => throw null;
                public virtual void Visit(System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiParameter> parameters) => throw null;
                public virtual void Visit(System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiExample> example) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiServerVariable> serverVariables) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiMediaType> content) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiLink> links) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiHeader> headers) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiExample> examples) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiEncoding> encodings) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Models.OpenApiCallback> callbacks) => throw null;
                public virtual void Visit(System.Collections.Generic.IDictionary<Microsoft.OpenApi.Models.OperationType, Microsoft.OpenApi.Models.OpenApiOperation> operations) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiTag tag) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiServerVariable serverVariable) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiServer server) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiSecurityScheme securityScheme) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiSecurityRequirement securityRequirement) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiSchema schema) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiResponses response) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiResponse response) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiRequestBody requestBody) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiPaths paths) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiPathItem pathItem) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiParameter parameter) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiOperation operation) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiOAuthFlow openApiOAuthFlow) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiMediaType mediaType) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiLink link) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiLicense license) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiInfo info) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiHeader tag) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiExternalDocs externalDocs) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiExample example) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiEncoding encoding) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiDocument doc) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiContact contact) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiComponents components) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Models.OpenApiCallback callback) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Interfaces.IOpenApiReferenceable referenceable) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Interfaces.IOpenApiExtension openApiExtension) => throw null;
                public virtual void Visit(Microsoft.OpenApi.Interfaces.IOpenApiExtensible openApiExtensible) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Services.OpenApiWalker` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiWalker
            {
                public OpenApiWalker(Microsoft.OpenApi.Services.OpenApiVisitorBase visitor) => throw null;
                public void Walk(Microsoft.OpenApi.Models.OpenApiDocument doc) => throw null;
            }

        }
        namespace Validations
        {
            // Generated from `Microsoft.OpenApi.Validations.IValidationContext` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IValidationContext
            {
                void AddError(Microsoft.OpenApi.Validations.OpenApiValidatorError error);
                void Enter(string segment);
                void Exit();
                string PathString { get; }
            }

            // Generated from `Microsoft.OpenApi.Validations.OpenApiValidator` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiValidator : Microsoft.OpenApi.Services.OpenApiVisitorBase, Microsoft.OpenApi.Validations.IValidationContext
            {
                public void AddError(Microsoft.OpenApi.Validations.OpenApiValidatorError error) => throw null;
                public System.Collections.Generic.IEnumerable<Microsoft.OpenApi.Validations.OpenApiValidatorError> Errors { get => throw null; }
                public OpenApiValidator(Microsoft.OpenApi.Validations.ValidationRuleSet ruleSet) => throw null;
                public override void Visit(System.Collections.Generic.IList<Microsoft.OpenApi.Models.OpenApiExample> items) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiTag item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiServer item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiSchema item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiResponses item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiResponse item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiParameter item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiOAuthFlow item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiMediaType item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiLicense item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiInfo item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiHeader item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiExternalDocs item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiEncoding item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiDocument item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiContact item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiComponents item) => throw null;
                public override void Visit(Microsoft.OpenApi.Models.OpenApiCallback item) => throw null;
                public override void Visit(Microsoft.OpenApi.Interfaces.IOpenApiExtension item) => throw null;
                public override void Visit(Microsoft.OpenApi.Interfaces.IOpenApiExtensible item) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Validations.OpenApiValidatorError` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiValidatorError : Microsoft.OpenApi.Models.OpenApiError
            {
                public OpenApiValidatorError(string ruleName, string pointer, string message) : base(default(Microsoft.OpenApi.Exceptions.OpenApiException)) => throw null;
                public string RuleName { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Validations.ValidationContextExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class ValidationContextExtensions
            {
                public static void CreateError(this Microsoft.OpenApi.Validations.IValidationContext context, string ruleName, string message) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Validations.ValidationRule` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public abstract class ValidationRule
            {
                protected ValidationRule() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Validations.ValidationRule<>` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class ValidationRule<T> : Microsoft.OpenApi.Validations.ValidationRule where T : Microsoft.OpenApi.Interfaces.IOpenApiElement
            {
                public ValidationRule(System.Action<Microsoft.OpenApi.Validations.IValidationContext, T> validate) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Validations.ValidationRuleSet` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class ValidationRuleSet : System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<Microsoft.OpenApi.Validations.ValidationRule>
            {
                public void Add(Microsoft.OpenApi.Validations.ValidationRule rule) => throw null;
                public System.Collections.Generic.IList<Microsoft.OpenApi.Validations.ValidationRule> FindRules(System.Type type) => throw null;
                public static Microsoft.OpenApi.Validations.ValidationRuleSet GetDefaultRuleSet() => throw null;
                public static Microsoft.OpenApi.Validations.ValidationRuleSet GetEmptyRuleSet() => throw null;
                public System.Collections.Generic.IEnumerator<Microsoft.OpenApi.Validations.ValidationRule> GetEnumerator() => throw null;
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw null;
                public System.Collections.Generic.IList<Microsoft.OpenApi.Validations.ValidationRule> Rules { get => throw null; }
                public ValidationRuleSet(System.Collections.Generic.IEnumerable<Microsoft.OpenApi.Validations.ValidationRule> rules) => throw null;
                public ValidationRuleSet(Microsoft.OpenApi.Validations.ValidationRuleSet ruleSet) => throw null;
                public ValidationRuleSet() => throw null;
            }

            namespace Rules
            {
                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiComponentsRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiComponentsRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiComponents> KeyMustBeRegularExpression { get => throw null; }
                    public static System.Text.RegularExpressions.Regex KeyRegex;
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiContactRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiContactRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiContact> EmailMustBeEmailFormat { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiDocumentRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiDocumentRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiDocument> OpenApiDocumentFieldIsMissing { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiExtensibleRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiExtensibleRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Interfaces.IOpenApiExtensible> ExtensionNameMustStartWithXDash { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiExternalDocsRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiExternalDocsRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiExternalDocs> UrlIsRequired { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiHeaderRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiHeaderRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiHeader> HeaderMismatchedDataType { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiInfoRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiInfoRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiInfo> InfoRequiredFields { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiLicenseRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiLicenseRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiLicense> LicenseRequiredFields { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiMediaTypeRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiMediaTypeRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiMediaType> MediaTypeMismatchedDataType { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiOAuthFlowRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiOAuthFlowRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiOAuthFlow> OAuthFlowRequiredFields { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiParameterRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiParameterRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiParameter> ParameterMismatchedDataType { get => throw null; }
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiParameter> ParameterRequiredFields { get => throw null; }
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiParameter> RequiredMustBeTrueWhenInIsPath { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiPathsRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiPathsRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiPaths> PathNameMustBeginWithSlash { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiResponseRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiResponseRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiResponse> ResponseRequiredFields { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiResponsesRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiResponsesRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiResponses> ResponsesMustBeIdentifiedByDefaultOrStatusCode { get => throw null; }
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiResponses> ResponsesMustContainAtLeastOneResponse { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiRuleAttribute` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public class OpenApiRuleAttribute : System.Attribute
                {
                    public OpenApiRuleAttribute() => throw null;
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiSchemaRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiSchemaRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiSchema> SchemaMismatchedDataType { get => throw null; }
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiSchema> ValidateSchemaDiscriminator { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiServerRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiServerRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiServer> ServerRequiredFields { get => throw null; }
                }

                // Generated from `Microsoft.OpenApi.Validations.Rules.OpenApiTagRules` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
                public static class OpenApiTagRules
                {
                    public static Microsoft.OpenApi.Validations.ValidationRule<Microsoft.OpenApi.Models.OpenApiTag> TagRequiredFields { get => throw null; }
                }

            }
        }
        namespace Writers
        {
            // Generated from `Microsoft.OpenApi.Writers.FormattingStreamWriter` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class FormattingStreamWriter : System.IO.StreamWriter
            {
                public override System.IFormatProvider FormatProvider { get => throw null; }
                public FormattingStreamWriter(System.IO.Stream stream, System.IFormatProvider formatProvider) : base(default(System.IO.Stream)) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Writers.IOpenApiWriter` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public interface IOpenApiWriter
            {
                void Flush();
                void WriteEndArray();
                void WriteEndObject();
                void WriteNull();
                void WritePropertyName(string name);
                void WriteRaw(string value);
                void WriteStartArray();
                void WriteStartObject();
                void WriteValue(string value);
                void WriteValue(object value);
                void WriteValue(int value);
                void WriteValue(bool value);
                void WriteValue(System.Decimal value);
            }

            // Generated from `Microsoft.OpenApi.Writers.OpenApiJsonWriter` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiJsonWriter : Microsoft.OpenApi.Writers.OpenApiWriterBase
            {
                protected override int BaseIndentation { get => throw null; }
                public OpenApiJsonWriter(System.IO.TextWriter textWriter, Microsoft.OpenApi.Writers.OpenApiWriterSettings settings) : base(default(System.IO.TextWriter)) => throw null;
                public OpenApiJsonWriter(System.IO.TextWriter textWriter) : base(default(System.IO.TextWriter)) => throw null;
                public override void WriteEndArray() => throw null;
                public override void WriteEndObject() => throw null;
                public override void WriteNull() => throw null;
                public override void WritePropertyName(string name) => throw null;
                public override void WriteRaw(string value) => throw null;
                public override void WriteStartArray() => throw null;
                public override void WriteStartObject() => throw null;
                public override void WriteValue(string value) => throw null;
                protected override void WriteValueSeparator() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Writers.OpenApiWriterAnyExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class OpenApiWriterAnyExtensions
            {
                public static void WriteAny<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, T any) where T : Microsoft.OpenApi.Any.IOpenApiAny => throw null;
                public static void WriteExtensions(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, System.Collections.Generic.IDictionary<string, Microsoft.OpenApi.Interfaces.IOpenApiExtension> extensions, Microsoft.OpenApi.OpenApiSpecVersion specVersion) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Writers.OpenApiWriterBase` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public abstract class OpenApiWriterBase : Microsoft.OpenApi.Writers.IOpenApiWriter
            {
                protected abstract int BaseIndentation { get; }
                protected Microsoft.OpenApi.Writers.Scope CurrentScope() => throw null;
                public virtual void DecreaseIndentation() => throw null;
                protected Microsoft.OpenApi.Writers.Scope EndScope(Microsoft.OpenApi.Writers.ScopeType type) => throw null;
                public void Flush() => throw null;
                public virtual void IncreaseIndentation() => throw null;
                protected bool IsArrayScope() => throw null;
                protected bool IsObjectScope() => throw null;
                protected bool IsTopLevelScope() => throw null;
                public OpenApiWriterBase(System.IO.TextWriter textWriter, Microsoft.OpenApi.Writers.OpenApiWriterSettings settings) => throw null;
                public OpenApiWriterBase(System.IO.TextWriter textWriter) => throw null;
                protected System.Collections.Generic.Stack<Microsoft.OpenApi.Writers.Scope> Scopes;
                public Microsoft.OpenApi.Writers.OpenApiWriterSettings Settings { get => throw null; set => throw null; }
                protected Microsoft.OpenApi.Writers.Scope StartScope(Microsoft.OpenApi.Writers.ScopeType type) => throw null;
                protected void VerifyCanWritePropertyName(string name) => throw null;
                public abstract void WriteEndArray();
                public abstract void WriteEndObject();
                public virtual void WriteIndentation() => throw null;
                public abstract void WriteNull();
                public abstract void WritePropertyName(string name);
                public abstract void WriteRaw(string value);
                public abstract void WriteStartArray();
                public abstract void WriteStartObject();
                public virtual void WriteValue(object value) => throw null;
                public virtual void WriteValue(int value) => throw null;
                public virtual void WriteValue(float value) => throw null;
                public virtual void WriteValue(double value) => throw null;
                public virtual void WriteValue(bool value) => throw null;
                public virtual void WriteValue(System.Int64 value) => throw null;
                public virtual void WriteValue(System.Decimal value) => throw null;
                public virtual void WriteValue(System.DateTimeOffset value) => throw null;
                public virtual void WriteValue(System.DateTime value) => throw null;
                public abstract void WriteValue(string value);
                protected abstract void WriteValueSeparator();
                protected System.IO.TextWriter Writer { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Writers.OpenApiWriterExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class OpenApiWriterExtensions
            {
                public static void WriteOptionalCollection<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IEnumerable<T> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, T> action) where T : Microsoft.OpenApi.Interfaces.IOpenApiElement => throw null;
                public static void WriteOptionalCollection(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IEnumerable<string> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, string> action) => throw null;
                public static void WriteOptionalMap<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IDictionary<string, T> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, string, T> action) where T : Microsoft.OpenApi.Interfaces.IOpenApiElement => throw null;
                public static void WriteOptionalMap<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IDictionary<string, T> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, T> action) where T : Microsoft.OpenApi.Interfaces.IOpenApiElement => throw null;
                public static void WriteOptionalMap(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IDictionary<string, string> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, string> action) => throw null;
                public static void WriteOptionalObject<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, T value, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, T> action) where T : Microsoft.OpenApi.Interfaces.IOpenApiElement => throw null;
                public static void WriteProperty<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, T? value) where T : struct => throw null;
                public static void WriteProperty<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, T value) where T : struct => throw null;
                public static void WriteProperty(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, string value) => throw null;
                public static void WriteProperty(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, bool? value, bool defaultValue = default(bool)) => throw null;
                public static void WriteProperty(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, bool value, bool defaultValue = default(bool)) => throw null;
                public static void WriteRequiredCollection<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IEnumerable<T> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, T> action) where T : Microsoft.OpenApi.Interfaces.IOpenApiElement => throw null;
                public static void WriteRequiredMap<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IDictionary<string, T> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, T> action) where T : Microsoft.OpenApi.Interfaces.IOpenApiElement => throw null;
                public static void WriteRequiredMap(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, System.Collections.Generic.IDictionary<string, string> elements, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, string> action) => throw null;
                public static void WriteRequiredObject<T>(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, T value, System.Action<Microsoft.OpenApi.Writers.IOpenApiWriter, T> action) where T : Microsoft.OpenApi.Interfaces.IOpenApiElement => throw null;
                public static void WriteRequiredProperty(this Microsoft.OpenApi.Writers.IOpenApiWriter writer, string name, string value) => throw null;
            }

            // Generated from `Microsoft.OpenApi.Writers.OpenApiWriterSettings` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiWriterSettings
            {
                public OpenApiWriterSettings() => throw null;
                public Microsoft.OpenApi.Writers.ReferenceInlineSetting ReferenceInline { get => throw null; set => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Writers.OpenApiYamlWriter` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class OpenApiYamlWriter : Microsoft.OpenApi.Writers.OpenApiWriterBase
            {
                protected override int BaseIndentation { get => throw null; }
                public OpenApiYamlWriter(System.IO.TextWriter textWriter, Microsoft.OpenApi.Writers.OpenApiWriterSettings settings) : base(default(System.IO.TextWriter)) => throw null;
                public OpenApiYamlWriter(System.IO.TextWriter textWriter) : base(default(System.IO.TextWriter)) => throw null;
                public override void WriteEndArray() => throw null;
                public override void WriteEndObject() => throw null;
                public override void WriteNull() => throw null;
                public override void WritePropertyName(string name) => throw null;
                public override void WriteRaw(string value) => throw null;
                public override void WriteStartArray() => throw null;
                public override void WriteStartObject() => throw null;
                public override void WriteValue(string value) => throw null;
                protected override void WriteValueSeparator() => throw null;
            }

            // Generated from `Microsoft.OpenApi.Writers.ReferenceInlineSetting` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum ReferenceInlineSetting
            {
                DoNotInlineReferences,
                InlineAllReferences,
                InlineLocalReferences,
                // Stub generator skipped constructor 
            }

            // Generated from `Microsoft.OpenApi.Writers.Scope` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public class Scope
            {
                public bool IsInArray { get => throw null; set => throw null; }
                public int ObjectCount { get => throw null; set => throw null; }
                public Scope(Microsoft.OpenApi.Writers.ScopeType type) => throw null;
                public Microsoft.OpenApi.Writers.ScopeType Type { get => throw null; }
            }

            // Generated from `Microsoft.OpenApi.Writers.ScopeType` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public enum ScopeType
            {
                Array,
                Object,
                // Stub generator skipped constructor 
            }

            // Generated from `Microsoft.OpenApi.Writers.SpecialCharacterStringExtensions` in `Microsoft.OpenApi, Version=1.2.3.0, Culture=neutral, PublicKeyToken=3f5743946376f042`
            public static class SpecialCharacterStringExtensions
            {
            }

        }
    }
}
