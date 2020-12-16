using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

namespace Semmle.Extraction.CIL.Entities
{
    /// <summary>
    /// A type that is not written directly in the trap file.
    /// todo: maybe we should store these as well in the DB. Currently if we see one of these and we're not in a fnptr parameter,
    /// than we write the ID of a type inot the reference, but the type is not going to be stored.
    /// </summary>
    internal abstract class NonStoredType : Type
    {
        protected NonStoredType(Context cx) : base(cx) { }

        public override CilTypeKind Kind => throw new NotImplementedException();

        public override Namespace? ContainingNamespace => throw new NotImplementedException();

        public override Type? ContainingType => throw new NotImplementedException();

        public override int ThisTypeParameterCount => throw new NotImplementedException();

        public override IEnumerable<Type> TypeParameters => throw new NotImplementedException();

        public override Type Construct(IEnumerable<Type> typeArguments)
        {
            throw new NotImplementedException();
        }
    }

    internal sealed class ByReferenceType : NonStoredType
    {
        public Type UnderlyingType { get; }

        public ByReferenceType(Context cx, Type underlyingType) : base(cx)
        {
            UnderlyingType = underlyingType;
        }

        public override string Name => $"ref {UnderlyingType.Name}";

        public override void WriteAssemblyPrefix(TextWriter trapFile) => UnderlyingType.WriteAssemblyPrefix(trapFile);

        public override void WriteId(TextWriter trapFile, bool inContext)
        {
            trapFile.Write("&");
            UnderlyingType.WriteId(trapFile, inContext);
        }
    }

    internal sealed class ModifiedType : NonStoredType
    {
        public Type Unmodified { get; }
        public Type Modifier { get; }
        public bool IsRequired { get; }

        public ModifiedType(Context cx, Type unmodified, Type modifier, bool isRequired) : base(cx)
        {
            Unmodified = unmodified;
            Modifier = modifier;
            IsRequired = isRequired;
        }

        public override string Name => (IsRequired ? "modreq" : "modopt") + $"({Modifier.Name}) {Unmodified.Name}";

        public override void WriteAssemblyPrefix(TextWriter trapFile) => Unmodified.WriteAssemblyPrefix(trapFile);

        public override void WriteId(TextWriter trapFile, bool inContext)
        {
            trapFile.Write(IsRequired ? "modreq" : "modopt");
            trapFile.Write("(");
            Modifier.WriteId(trapFile, inContext);
            trapFile.Write(") ");
            Unmodified.WriteId(trapFile, inContext);
        }
    }

    internal sealed class FunctionPointerType : Type, IParameterizable
    {
        private readonly MethodSignature<Type> signature;

        public FunctionPointerType(Context cx, MethodSignature<Type> signature) : base(cx)
        {
            this.signature = signature;
        }

        public override CilTypeKind Kind => CilTypeKind.FunctionPointer;

        public override string Name
        {
            get
            {
                using var id = new StringWriter();
                WriteName(
                    id.Write,
                    t => id.Write(t.Name)
                );
                return id.ToString();
            }
        }

        public override Namespace? ContainingNamespace => Cx.GlobalNamespace;

        public override Type? ContainingType => null;

        public override int ThisTypeParameterCount => throw new System.NotImplementedException();

        public override IEnumerable<Type> TypeParameters => throw new System.NotImplementedException();

        public override Type Construct(IEnumerable<Type> typeArguments) => throw new System.NotImplementedException();

        public override void WriteAssemblyPrefix(TextWriter trapFile) { }

        public override void WriteId(TextWriter trapFile, bool inContext)
        {
            WriteName(
                trapFile.Write,
                t => t.WriteId(trapFile, inContext)
            );
        }

        private void WriteName(Action<string> write, Action<Type> writeType)
        {
            write("delegate* ");
            write(GetCallingConvention(signature.Header.CallingConvention));
            write("<");
            foreach (var pt in signature.ParameterTypes)
            {
                writeType(pt);
                write(",");
            }
            writeType(signature.ReturnType);
            write(">");
        }

        internal static string GetCallingConvention(SignatureCallingConvention callingConvention)
        {
            if (callingConvention == SignatureCallingConvention.Default)
            {
                return "managed";
            }

            if (callingConvention == SignatureCallingConvention.Unmanaged)
            {
                return "unmanaged";
            }

            return $"unmanaged[{callingConvention}]";
        }

        public override IEnumerable<IExtractionProduct> Contents
        {
            get
            {
                foreach (var c in base.Contents)
                {
                    yield return c;
                }

                if (signature.ReturnType is ByReferenceType byRef)
                {
                    yield return Tuples.cil_function_pointer_return_type(this, byRef.UnderlyingType, true);
                }
                else
                {
                    yield return Tuples.cil_function_pointer_return_type(this, signature.ReturnType, false);
                }

                yield return Tuples.cil_function_pointer_calling_conventions(this, signature.Header.CallingConvention);

                var i = 0;
                foreach (var p in signature.ParameterTypes)
                {
                    var parameterType = GetUnmodifiedType(p);
                    var param = Cx.Populate(new Parameter(Cx, this, i++, parameterType));
                    yield return param;

                    foreach (var mod in GetModifiers(p, param))
                    {
                        yield return mod;
                    }
                }
            }
        }

        private IEnumerable<IExtractionProduct> GetModifiers(Type type, Parameter param)
        {
            if (type is ByReferenceType)
            {
                return new[] { Tuples.cil_parameter_ref(param) };
            }

            if (type is ModifiedType mod)
            {
                var qualifiedName = mod.Modifier.GetQualifiedName();
                switch (qualifiedName)
                {
                    case "System.Runtime.InteropServices.InAttribute":
                        return new[] { Tuples.cil_parameter_in(param) }.Concat(GetModifiers(mod.Unmodified, param));
                    case "System.Runtime.InteropServices.OutAttribute":
                        return new[] { Tuples.cil_parameter_out(param) }.Concat(GetModifiers(mod.Unmodified, param));
                    default:
                        Cx.Cx.Extractor.Logger.Log(Util.Logging.Severity.Info, $"Found unknown modifier '{qualifiedName}' in function pointer declaration '{Name}'");
                        return GetModifiers(mod.Unmodified, param);
                }
            }

            return Enumerable.Empty<IExtractedEntity>();
        }

        private static Type GetUnmodifiedType(Type type)
        {
            return type switch
            {
                ByReferenceType byRefParam => byRefParam.UnderlyingType,
                ModifiedType modified => GetUnmodifiedType(modified.Unmodified),
                _ => type
            };
        }
    }
}
