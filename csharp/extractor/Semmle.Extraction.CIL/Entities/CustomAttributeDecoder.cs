using System;
using System.Reflection.Metadata;

namespace Semmle.Extraction.CIL.Entities
{
    /// <summary>
    /// Helper class to decode the attribute structure.
    /// Note that there are some unhandled cases that should be fixed in due course.
    /// </summary>
    internal class CustomAttributeDecoder : ICustomAttributeTypeProvider<Type>
    {
        private readonly Context cx;
        public CustomAttributeDecoder(Context cx) { this.cx = cx; }

        public Type GetPrimitiveType(PrimitiveTypeCode typeCode) => cx.Create(typeCode);

        public Type GetSystemType() => new NoMetadateHandleType(cx, "System.Type");

        public Type GetSZArrayType(Type elementType) =>
            cx.Populate(new ArrayType(cx, elementType));

        public Type GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind) =>
            (Type)cx.Create(handle);

        public Type GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind) =>
            (Type)cx.Create(handle);

        public Type GetTypeFromSerializedName(string name) => new NoMetadateHandleType(cx, name);

        public PrimitiveTypeCode GetUnderlyingEnumType(Type type) =>
            type is TypeDefinitionType tdt && tdt.GetUnderlyingEnumType() is var underlying && underlying.HasValue
                ? underlying.Value
                : PrimitiveTypeCode.Int32; // Best guess. If we miss, BadFormatException will be thrown.

        public bool IsSystemType(Type type) => type is INamedType nt && nt.GetQualifiedName() == "System.Type";
    }
}
