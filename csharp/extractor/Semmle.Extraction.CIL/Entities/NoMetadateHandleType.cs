using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Semmle.Util;

namespace Semmle.Extraction.CIL.Entities
{
    public sealed class NoMetadateHandleType : Type
    {
        private readonly string originalName;
        private readonly string name;
        private readonly string assemblyName;
        private readonly string containerName;
        private readonly bool isContainerNamespace;

        private readonly Lazy<TypeTypeParameter[]> typeParams;

        // Either null or notEmpty
        private readonly Type[]? thisTypeArguments;
        private readonly Type unboundGenericType;

        private readonly NamedTypeIdWriter idWriter;

        public NoMetadateHandleType(Context cx, string name) : base(cx)
        {
            idWriter = new NamedTypeIdWriter(this);
            originalName = name;

            // N1.N2.T1`3+T2`1[T3,[T4, Assembly1, Version=...],T5,T6], Assembly2, Version=...
            // for example:
            // typeof(System.Collections.Generic.List<int>.Enumerator)
            // -> System.Collections.Generic.List`1+Enumerator[[System.Int32, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
            // typeof(System.Collections.Generic.List<>.Enumerator)
            // -> System.Collections.Generic.List`1+Enumerator, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e

            var lastBracketIndex = name.LastIndexOf(']');
            var assemblyCommaIndex = name.IndexOf(',', lastBracketIndex < 0 ? 0 : lastBracketIndex);
            if (assemblyCommaIndex >= 0)
            {
                assemblyName = name.Substring(assemblyCommaIndex + 2);
                name = name.Substring(0, assemblyCommaIndex);
            }

            var firstBracketIndex = name.IndexOf('[');
            if (firstBracketIndex >= 0)
            {
                // create types for arguments.
                // this type is a constructed generic
                // create non constructed one too.
                throw new NotImplementedException();
                // name = name.Substring(0, firstBracketIndex);

                // adjust containing type which can also be a constructed generic

                // thisTypeArguments = ;
                // unboundGenericType = ;
                // containerName = ;
            }
            else
            {
                thisTypeArguments = null;
                unboundGenericType = this;
            }

            var lastPlusIndex = name.LastIndexOf('+');
            if (lastPlusIndex >= 0)
            {
                containerName = name.Substring(0, lastPlusIndex);
                name = name.Substring(lastPlusIndex + 1);
                isContainerNamespace = false;
            }
            else
            {
                var lastDotIndex = name.LastIndexOf('.');
                if (lastDotIndex >= 0)
                {
                    containerName = name.Substring(0, lastDotIndex);
                    name = name.Substring(lastDotIndex + 1);
                }
                else
                {
                    containerName = ""; // global namespace
                }
                isContainerNamespace = true;
            }

            this.name = name;
            this.typeParams = new Lazy<TypeTypeParameter[]>(GenericsHelper.MakeTypeParameters(this, ThisTypeParameterCount));

            if (isContainerNamespace)
            {
                cx.Populate(ContainingNamespace);
            }

            cx.Populate(this);
        }

        public override bool Equals(object? obj)
        {
            return obj is NoMetadateHandleType t && originalName.Equals(t.originalName, StringComparison.Ordinal);
        }

        public override int GetHashCode()
        {
            return originalName.GetHashCode(StringComparison.Ordinal);
        }

        public override IEnumerable<IExtractionProduct> Contents
        {
            get
            {
                foreach (var tp in typeParams.Value)
                    yield return tp;

                foreach (var c in base.Contents)
                    yield return c;

                var i = 0;
                foreach (var type in ThisTypeArguments)
                {
                    yield return type;
                    yield return Tuples.cil_type_argument(this, i++, type);
                }
            }
        }

        public override CilTypeKind Kind => CilTypeKind.ValueOrRefType;

        public override string Name => GenericsHelper.GetNonGenericName(name);

        public override Namespace? ContainingNamespace => isContainerNamespace
            ? new Namespace(Cx, containerName)
            : null;

        public override Type? ContainingType => isContainerNamespace
            ? null
            : new NoMetadateHandleType(
                Cx,
                string.IsNullOrWhiteSpace(assemblyName)
                    ? containerName
                    : containerName + ", " + assemblyName);

        public override int ThisTypeParameterCount => GenericsHelper.GetGenericTypeParameterCount(name);

        public override IEnumerable<Type> TypeParameters => typeParams.Value;

        public override IEnumerable<Type> ThisTypeArguments => thisTypeArguments.EnumerateNull();

        public override Type SourceDeclaration => unboundGenericType;

        public override Type Construct(IEnumerable<Type> typeArguments)
        {
            if (TotalTypeParametersCount != typeArguments.Count())
                throw new InternalError("Mismatched type arguments");

            return Cx.Populate(new ConstructedType(Cx, this, typeArguments));
        }

        public override void WriteAssemblyPrefix(TextWriter trapFile)
        {
            if (!string.IsNullOrWhiteSpace(assemblyName))
            {
                var an = new AssemblyName(assemblyName);
                trapFile.Write(an.Name);
                trapFile.Write('_');
                trapFile.Write((an.Version ?? new Version(0, 0, 0, 0)).ToString());
                trapFile.Write("::");
            }
            else
            {
                Cx.WriteAssemblyPrefix(trapFile);
            }
        }

        public override void WriteId(TextWriter trapFile, bool inContext)
        {
            idWriter.WriteId(trapFile, inContext);
        }
    }
}
