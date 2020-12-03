using System.Reflection.Metadata;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System;

namespace Semmle.Extraction.CIL.Entities
{
    /// <summary>
    /// A type.
    /// </summary>
    public abstract class Type : TypeContainer, IMember
    {
        protected Type(Context cx) : base(cx) { }

        public sealed override string IdSuffix => ";cil-type";

        /// <summary>
        /// Find the method in this type matching the name and signature.
        /// </summary>
        /// <param name="methodName">The handle to the name.</param>
        /// <param name="signature">
        /// The handle to the signature. Note that comparing handles is a valid
        /// shortcut to comparing the signature bytes since handles are unique.
        /// </param>
        /// <returns>The method, or 'null' if not found or not supported.</returns>
        internal virtual Method? LookupMethod(StringHandle methodName, BlobHandle signature)
        {
            return null;
        }

        /// <summary>
        /// Writes the assembly identifier of this type.
        /// </summary>
        public abstract void WriteAssemblyPrefix(TextWriter trapFile);

        public sealed override void WriteId(TextWriter trapFile) => WriteId(trapFile, false);

        /// <summary>
        /// Writes the ID part to be used in a method ID.
        /// </summary>
        /// <param name="inContext">
        /// Whether we should output the context prefix of type parameters.
        /// (This is to avoid infinite recursion generating a method ID that returns a
        /// type parameter.)
        /// </param>
        public abstract void WriteId(TextWriter trapFile, bool inContext);

        public void GetId(TextWriter trapFile, bool inContext) => WriteId(trapFile, inContext);

        /// <summary>
        /// Returns the friendly qualified name of types, such as ``"System.Collection.Generic`"`` or
        /// `"System.Collection.Generic<System.Int32>"`.
        ///
        /// Note that method/type generic type parameters never show up in the returned name.
        /// </summary>
        public string GetQualifiedName()
        {
            using var writer = new StringWriter();
            GetId(writer, false);
            writer.Flush();
            var name = writer.ToString();
            return name.Substring(name.LastIndexOf(':') + 1);
        }

        public abstract CilTypeKind Kind { get; }

        public override IEnumerable<IExtractionProduct> Contents
        {
            get
            {
                yield return Tuples.cil_type(this, Name, Kind, Parent, SourceDeclaration);
            }
        }

        public abstract string Name { get; }

        public abstract Namespace? ContainingNamespace { get; }

        public abstract Type? ContainingType { get; }

        public virtual TypeContainer Parent => (TypeContainer?)ContainingType ?? ContainingNamespace!;

        public abstract Type Construct(IEnumerable<Type> typeArguments);

        /// <summary>
        /// The number of type parameters, or 0 if this isn't generic.
        /// The containing type may also have type parameters.
        /// </summary>
        public abstract int ThisTypeParameterCount { get; }

        /// <summary>
        /// The total number of type parameters (including parent types).
        /// This is used for internal consistency checking only.
        /// </summary>
        public int TotalTypeParametersCount => ContainingType == null
            ? ThisTypeParameterCount
            : ThisTypeParameterCount + ContainingType.TotalTypeParametersCount;

        /// <summary>
        /// Returns all bound/unbound generic arguments
        /// of a constructed/unbound generic type.
        /// </summary>
        public virtual IEnumerable<Type> ThisTypeArguments
        {
            get
            {
                yield break;
            }
        }
        public virtual Type SourceDeclaration => this;

        public static void WritePrimitiveTypeId(TextWriter trapFile, string name)
        {
            trapFile.Write(PrimitiveType.Prefix);
            trapFile.Write(name);
        }

        private static readonly Dictionary<string, PrimitiveTypeCode> primitiveTypeCodeMapping = new Dictionary<string, PrimitiveTypeCode>
        {
            {"Boolean", PrimitiveTypeCode.Boolean},
            {"Object", PrimitiveTypeCode.Object},
            {"Byte", PrimitiveTypeCode.Byte},
            {"SByte", PrimitiveTypeCode.SByte},
            {"Int16", PrimitiveTypeCode.Int16},
            {"UInt16", PrimitiveTypeCode.UInt16},
            {"Int32", PrimitiveTypeCode.Int32},
            {"UInt32", PrimitiveTypeCode.UInt32},
            {"Int64", PrimitiveTypeCode.Int64},
            {"UInt64", PrimitiveTypeCode.UInt64},
            {"Single", PrimitiveTypeCode.Single},
            {"Double", PrimitiveTypeCode.Double},
            {"String", PrimitiveTypeCode.String},
            {"Void", PrimitiveTypeCode.Void},
            {"IntPtr", PrimitiveTypeCode.IntPtr},
            {"UIntPtr", PrimitiveTypeCode.UIntPtr},
            {"Char", PrimitiveTypeCode.Char},
            {"TypedReference", PrimitiveTypeCode.TypedReference}
        };

        /// <summary>
        /// Gets the primitive type corresponding to this type, if possible.
        /// </summary>
        /// <param name="t">The resulting primitive type, or null.</param>
        /// <returns>True if this type is a primitive type.</returns>
        public bool TryGetPrimitiveType([NotNullWhen(true)] out PrimitiveType? t)
        {
            if (TryGetPrimitiveTypeCode(out var code))
            {
                t = Cx.Create(code);
                return true;
            }

            t = null;
            return false;
        }

        private bool TryGetPrimitiveTypeCode(out PrimitiveTypeCode code)
        {
            if (ContainingType == null &&
                ContainingNamespace?.Name == Cx.SystemNamespace.Name &&
                primitiveTypeCodeMapping.ContainsKey(Name))
            {
                code = primitiveTypeCodeMapping[Name];
                return true;
            }

            code = default;
            return false;
        }

        protected internal bool IsPrimitiveType => TryGetPrimitiveTypeCode(out _);

        public override IEnumerable<Type> MethodParameters => throw new InternalError("Types have no generic method parameters");

        public static Type DecodeType(GenericContext gc, TypeSpecificationHandle handle) =>
            gc.Cx.MdReader.GetTypeSpecification(handle).DecodeSignature(gc.Cx.TypeSignatureDecoder, gc);
    }
}
