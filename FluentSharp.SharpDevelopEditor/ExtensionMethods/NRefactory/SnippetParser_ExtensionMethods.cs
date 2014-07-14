using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentSharp.CoreLib;
using ICSharpCode.NRefactory;
using ICSharpCode.NRefactory.Ast;

namespace FluentSharp.SharpDevelopEditor
{
    public static class SnippetParser_ExtensionMethods
    {
        public static INode snippetParser_Parse(this string code)
        {
            if(code.notValid())
                return null;
            var snippetParser = new SnippetParser(SupportedLanguage.CSharp);             
            return snippetParser.Parse(code);
        }
    }
}
