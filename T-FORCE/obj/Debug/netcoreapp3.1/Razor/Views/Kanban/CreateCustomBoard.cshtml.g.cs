#pragma checksum "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3e883e288211d685c6ef89cdd1bff64c57a29c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kanban_CreateCustomBoard), @"mvc.1.0.view", @"/Views/Kanban/CreateCustomBoard.cshtml")]
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
#line 1 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml"
using T_FORCE.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3e883e288211d685c6ef89cdd1bff64c57a29c", @"/Views/Kanban/CreateCustomBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f582b379e209711f2143c0b1b9f95e968909e96b", @"/Views/_ViewImports.cshtml")]
    public class Views_Kanban_CreateCustomBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml"
   ViewData["Title"] = "Create new Kanban board"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""container"" style=""padding: 2%"">
    <h1 class=""h3 mb-3 text-gray-800"">Create custom Kanban board</h1>
    <p class=""mb-1"">Create new Custom Kanban board by setting it's attributes.</p>
    <p class=""mb-4"">Switching task columns in custom boards will not reflect the actual task status.</p>


    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">New Custom Kanban board attributes</h6>
        </div>
        <div class=""card-body"" name=""card-body"" id=""card-body"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd3e883e288211d685c6ef89cdd1bff64c57a29c4720", async() => {
                WriteLiteral(@"
                <div id=""options"" name=""options"">
                    <label for=""bname""><b>Board name</b></label>
                    <input id=""name"" type=""text"" class=""form-control"" placeholder=""Enter board name"" name=""name"" required>

                    <label for=""projectSelector""><b>Project</b></label>
                    <select id=""projectName"" name=""projectName"" class=""form-control"" required>
");
#nullable restore
#line 24 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml"
                          
                            ProjectRepository projectRepository = new ProjectRepository();
                            foreach (Project project in projectRepository.GetAllProjects())
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd3e883e288211d685c6ef89cdd1bff64c57a29c5889", async() => {
#nullable restore
#line 28 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml"
                                                         Write(project.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml"
                                   WriteLiteral(project.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                    <label id=""bColumnNamesLabel"" for=""bColumnNamesLabel""></label>
                    <ul class=""list-group"" id=""columnsNames"" name=""columnsNames"">
                    </ul>
                    <label for=""bColumnName""><b>Column name</b></label>
                    <input type=""text"" class=""form-control"" placeholder=""Enter column name"" name=""columnName"" id=""columnName"" required>
                </div>
                <div class=""my-3"">
                    <input class=""btn btn-primary"" onclick=""GenerateColumnNameInput()"" type=""button"" value=""Add column"" />
                    <input class=""btn btn-success"" type=""submit"" value=""Create"" />
                    <input class=""btn btn-danger"" onclick=""window.location.href='/'"" type=""button"" value=""Cancel"" />
                </div>
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
#line 17 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\CreateCustomBoard.cshtml"
AddHtmlAttributeValue("", 692, Url.Action("CreateCustomBoard","Kanban"), 692, 41, false);

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
            WriteLiteral(@"
        </div>
    </div>
</div>


<!-- Dynamic options menu for column names based on the number of columns -->
<script type=""text/javascript"">
    function GenerateColumnNameInput() {

        var columnInput = document.getElementById(""columnName"");

        var newColumnLabel = document.getElementById(""bColumnNamesLabel"");

        if (newColumnLabel.innerHTML == """") {
            newColumnLabel.innerHTML = ""<b>Columns</b>"";
        }

        if (columnInput.value != '') {
            var columnsNewElement = document.createElement(""input"");
            columnsNewElement.setAttribute('name', 'columnNamesElements');
            columnsNewElement.setAttribute('class', 'list-group-item list-group-item-action');
            columnsNewElement.setAttribute('onchange', 'ColumnNamesLiOnChange(this)');
            columnsNewElement.value = columnInput.value;

            document.getElementById(""columnsNames"").appendChild(columnsNewElement);

            columnInput.value = '';
        ");
            WriteLiteral(@"}
    }
    //If the Task Statuses li user imput gets empty, remove the element!
    function ColumnNamesLiOnChange(obj) {

        var newColumnLabel = document.getElementById(""bColumnNamesLabel"");

        if (document.getElementById(""columnNamesElements"") == null) {
            newColumnLabel.innerHTML = """";
        }

        if (obj.value === '') {
            obj.remove();
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
