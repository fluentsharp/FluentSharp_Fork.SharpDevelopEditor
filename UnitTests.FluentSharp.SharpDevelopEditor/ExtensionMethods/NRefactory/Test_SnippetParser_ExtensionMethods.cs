using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentSharp.CoreLib;
using FluentSharp.CSharpAST;
using FluentSharp.NUnit;
using FluentSharp.SharpDevelopEditor;
using FluentSharp.WinForms;
using NUnit.Framework;

namespace UnitTests.FluentSharp.SharpDevelopEditor
{
    [TestFixture]
    public class Test_SnippetParser_ExtensionMethods
    {
        [Test]
        public void snippetParser_Parse()
        {
            var code_Raw       = "var a= 2+2;";
            var code_Parsed    = "var a = 2 + 2;\r\n";
            var code_INode     = code_Raw  .snippetParser_Parse()   .assert_Not_Null();
            var csharpCode     = code_INode.csharpCode()            .assert_Valid();
            csharpCode.assert_Equals(code_Parsed);            

            "var 123"       .snippetParser_Parse().assert_Not_Null().csharpCode().assert_Empty();
            "aaa ' bbb"     .snippetParser_Parse().assert_Not_Null().csharpCode().assert_Empty();
            (null as string).snippetParser_Parse().assert_Null();
        }
    }
}
