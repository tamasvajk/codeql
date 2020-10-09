using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Semmle.Extraction.Entities;
using System.IO;

namespace Semmle.Extraction.CSharp.Entities
{
    internal class Attribute : CachedEntity<AttributeSyntax>, IExpressionParentEntity
    {
        bool IExpressionParentEntity.IsTopLevelParent => true;

        private readonly INamedTypeSymbol attributeClass;
        private readonly IEntity entity;

        private Attribute(Context cx, AttributeSyntax attributeSyntax, INamedTypeSymbol attributeClass, IEntity entity)
            : base(cx, attributeSyntax)
        {
            this.attributeClass = attributeClass;
            this.entity = entity;
        }

        public override void WriteId(TextWriter trapFile)
        {
            if (ReportingLocation?.IsInSource == true)
            {
                trapFile.WriteSubId(Context.Create(ReportingLocation));
                trapFile.Write(";attribute");
            }
            else
            {
                trapFile.Write('*');
            }
        }

        public override void Populate(TextWriter trapFile)
        {
            var type = Type.Create(Context, attributeClass);
            trapFile.attributes(this, type.TypeRef, entity);

            trapFile.attribute_location(this, Context.Create(symbol.Name.GetLocation()));

            if (Context.Extractor.OutputPath != null)
                trapFile.attribute_location(this, Assembly.CreateOutputAssembly(Context));

            TypeMention.Create(Context, symbol.Name, this, type);

            if (symbol.ArgumentList != null)
            {
                Context.PopulateLater(() =>
                {
                    int child = 0;
                    foreach (var arg in symbol.ArgumentList.Arguments)
                    {
                        var expr = Expression.Create(Context, arg.Expression, this, child++);
                        if (!(arg.NameEquals is null))
                        {
                            trapFile.expr_argument_name(expr, arg.NameEquals.Name.Identifier.Text);
                        }
                    }
                });
            }
        }

        private static void Create(Context cx, AttributeData attributeData, IEntity entity)
        {
            if (!(attributeData.ApplicationSyntaxReference?.GetSyntax() is AttributeSyntax syntax))
            {
                return;
            }

            var init = (syntax, attributeData.AttributeClass, entity);
            AttributeFactory.Instance.CreateEntity(cx, init, init);
        }

        public static Attribute Create(Context cx, AttributeSyntax attributeSyntax, IEntity entity)
        {
            var type = cx.GetSymbolInfo(attributeSyntax).Symbol.ContainingType;
            var init = (attributeSyntax, type, entity);
            return AttributeFactory.Instance.CreateEntity(cx, init, init);
        }

        private class AttributeFactory : ICachedEntityFactory<(AttributeSyntax syntax, INamedTypeSymbol typeSymbol, IEntity receiver), Attribute>
        {
            public static readonly AttributeFactory Instance = new AttributeFactory();

            public Attribute Create(Context cx, (AttributeSyntax syntax, INamedTypeSymbol typeSymbol, IEntity receiver) init) =>
                new Attribute(cx, init.syntax, init.typeSymbol, init.receiver);
        }

        public static void ExtractAttributes(Context cx, ISymbol symbol, IEntity entity)
        {
            foreach (var attribute in symbol.GetAttributes())
            {
                Create(cx, attribute, entity);
            }
        }

        public override Microsoft.CodeAnalysis.Location ReportingLocation => symbol.Name.GetLocation();

        public override bool NeedsPopulation => true;

        public override TrapStackBehaviour TrapStackBehaviour => TrapStackBehaviour.OptionalLabel;
    }
}
