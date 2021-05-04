// This file contains auto-generated code.

namespace Microsoft
{
    namespace AspNetCore
    {
        namespace Builder
        {
            // Generated from `Microsoft.AspNetCore.Builder.SwaggerBuilderExtensions` in `Swashbuckle.AspNetCore.Swagger, Version=6.1.4.0, Culture=neutral, PublicKeyToken=62657d7474907593`
            public static class SwaggerBuilderExtensions
            {
                public static Microsoft.AspNetCore.Routing.IEndpointRouteBuilder MapSwagger(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern = default(string), System.Action<Swashbuckle.AspNetCore.Swagger.SwaggerEndpointOptions> setupAction = default(System.Action<Swashbuckle.AspNetCore.Swagger.SwaggerEndpointOptions>)) => throw null;
                public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseSwagger(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Action<Swashbuckle.AspNetCore.Swagger.SwaggerOptions> setupAction = default(System.Action<Swashbuckle.AspNetCore.Swagger.SwaggerOptions>)) => throw null;
                public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseSwagger(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Swashbuckle.AspNetCore.Swagger.SwaggerOptions options) => throw null;
            }

        }
    }
}
namespace Swashbuckle
{
    namespace AspNetCore
    {
        namespace Swagger
        {
            // Generated from `Swashbuckle.AspNetCore.Swagger.ISwaggerProvider` in `Swashbuckle.AspNetCore.Swagger, Version=6.1.4.0, Culture=neutral, PublicKeyToken=62657d7474907593`
            public interface ISwaggerProvider
            {
                Microsoft.OpenApi.Models.OpenApiDocument GetSwagger(string documentName, string host = default(string), string basePath = default(string));
            }

            // Generated from `Swashbuckle.AspNetCore.Swagger.SwaggerEndpointOptions` in `Swashbuckle.AspNetCore.Swagger, Version=6.1.4.0, Culture=neutral, PublicKeyToken=62657d7474907593`
            public class SwaggerEndpointOptions
            {
                public System.Collections.Generic.List<System.Action<Microsoft.OpenApi.Models.OpenApiDocument, Microsoft.AspNetCore.Http.HttpRequest>> PreSerializeFilters { get => throw null; set => throw null; }
                public bool SerializeAsV2 { get => throw null; set => throw null; }
                public SwaggerEndpointOptions() => throw null;
            }

            // Generated from `Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware` in `Swashbuckle.AspNetCore.Swagger, Version=6.1.4.0, Culture=neutral, PublicKeyToken=62657d7474907593`
            public class SwaggerMiddleware
            {
                public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext httpContext, Swashbuckle.AspNetCore.Swagger.ISwaggerProvider swaggerProvider) => throw null;
                public SwaggerMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Swashbuckle.AspNetCore.Swagger.SwaggerOptions options) => throw null;
            }

            // Generated from `Swashbuckle.AspNetCore.Swagger.SwaggerOptions` in `Swashbuckle.AspNetCore.Swagger, Version=6.1.4.0, Culture=neutral, PublicKeyToken=62657d7474907593`
            public class SwaggerOptions
            {
                public System.Collections.Generic.List<System.Action<Microsoft.OpenApi.Models.OpenApiDocument, Microsoft.AspNetCore.Http.HttpRequest>> PreSerializeFilters { get => throw null; set => throw null; }
                public string RouteTemplate { get => throw null; set => throw null; }
                public bool SerializeAsV2 { get => throw null; set => throw null; }
                public SwaggerOptions() => throw null;
            }

            // Generated from `Swashbuckle.AspNetCore.Swagger.UnknownSwaggerDocument` in `Swashbuckle.AspNetCore.Swagger, Version=6.1.4.0, Culture=neutral, PublicKeyToken=62657d7474907593`
            public class UnknownSwaggerDocument : System.InvalidOperationException
            {
                public UnknownSwaggerDocument(string documentName, System.Collections.Generic.IEnumerable<string> knownDocuments) => throw null;
            }

        }
    }
}
