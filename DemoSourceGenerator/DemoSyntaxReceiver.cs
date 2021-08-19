using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSourceGenerator
{
    public class DemoSyntaxReceiver : ISyntaxReceiver
    {
        //public List<ClassDeclarationSyntax> Candidates => new();

        private List<ClassDeclarationSyntax> _candidates = new List<ClassDeclarationSyntax>();
        public List<ClassDeclarationSyntax> Candidates => _candidates;

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is not AttributeSyntax attribute)
                return;

            var name = ExtractName(attribute.Name);

            if (name != "EnumGeneration" && name != "EnumGenerationAttribute")
                return;

            // "attribute.Parent" is "AttributeListSyntax"
            // "attribute.Parent.Parent" is a C# fragment the attribute is applied to
            if (attribute.Parent?.Parent is ClassDeclarationSyntax)
            {
                var classDeclaration = (ClassDeclarationSyntax)attribute.Parent?.Parent;
                //Candidates.Add(classDeclaration);
                _candidates.Add(classDeclaration);
            }
                
        }

        private static string ExtractName(TypeSyntax type)
        {
            while (type != null)
            {
                switch (type)
                {
                    case IdentifierNameSyntax ins:
                        return ins.Identifier.Text;
                    case QualifiedNameSyntax qns:
                        type = qns.Right;
                        break;
                    default:
                        return null;
                }
            }

            return null;
        }

    }

}
