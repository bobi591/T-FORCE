#pragma checksum "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5da5536f7d73a0c1532974ab20165da9ce41e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks__Comments), @"mvc.1.0.view", @"/Views/Tasks/_Comments.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\_ViewImports.cshtml"
using T_FORCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\_ViewImports.cshtml"
using T_FORCE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
using T_FORCE.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5da5536f7d73a0c1532974ab20165da9ce41e1", @"/Views/Tasks/_Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f582b379e209711f2143c0b1b9f95e968909e96b", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks__Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<T_FORCE.Models.Task>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Comments section -->\r\n<!--Created comments-->\r\n");
#nullable restore
#line 6 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
  
    UserRepository userRepository = new UserRepository();
    foreach (Comment comment in Model.GetComments())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n\r\n            <div class=\"col-lg-6\">\r\n\r\n                <!-- Default Card Example -->\r\n                <div class=\"card mb-4\">\r\n                    <div class=\"card-header\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
                   Write(userRepository.GetUserById(comment.UserId).GetFirstNameLastName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" commented:\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
                   Write(Html.Raw(comment.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <i style=\"font-size:80%; color:darkslategrey; text-align:right;\">");
#nullable restore
#line 21 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
                                                                                    Write(comment.LastModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--New comment card-->\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-primary\">Create new comment</h6>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d5da5536f7d73a0c1532974ab20165da9ce41e15894", async() => {
                WriteLiteral("\r\n            <input name=\"taskId\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1211, "\"", 1228, 1);
#nullable restore
#line 37 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
WriteAttributeValue("", 1219, Model.Id, 1219, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden />
            <textarea id=""summernote"" name=""comment""></textarea>
            <div class=""my-2""></div>
            <input class=""btn btn-primary"" type=""submit"" value=""Comment"" />
            <input class=""btn btn-danger"" onclick=""window.location.href='/'"" type=""button"" value=""Cancel"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\_Comments.cshtml"
AddHtmlAttributeValue("", 1133, Url.Action("Comment","Tasks"), 1133, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<T_FORCE.Models.Task> Html { get; private set; }
    }
}
#pragma warning restore 1591