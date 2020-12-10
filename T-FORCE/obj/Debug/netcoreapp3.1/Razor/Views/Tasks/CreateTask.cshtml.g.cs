#pragma checksum "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "148880db4f1971a3fe7e2c06064a29b434c0d3e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_CreateTask), @"mvc.1.0.view", @"/Views/Tasks/CreateTask.cshtml")]
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
#line 2 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
using T_FORCE.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148880db4f1971a3fe7e2c06064a29b434c0d3e1", @"/Views/Tasks/CreateTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f582b379e209711f2143c0b1b9f95e968909e96b", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_CreateTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Select", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
   ViewData["Title"] = "Create Task"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--This script inclusion should be here only, because it enables summernote but does not glich the card expansion functionality!-->
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

<div id=""container"" style=""padding: 2%"">
    <h1 class=""h3 mb-1 text-gray-800"">Create Task</h1>
    <p class=""mb-4"">Create new task by setting it's attributes</p>


    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">New task attributes</h6>
        </div>
        <div class=""card-body"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "148880db4f1971a3fe7e2c06064a29b434c0d3e15067", async() => {
                WriteLiteral(@"
                <label for=""tname""><b>Task name</b></label>
                <input type=""text"" class=""form-control"" placeholder=""Enter Task Name"" name=""name"" required>

                <label for=""tdescription""><b>Task content</b></label>
                <textarea id=""summernote"" name=""description""></textarea>

                <label for=""projectSelector""><b>Project</b></label>
                <select id=""projectName"" name=""projectName"" class=""form-control"" 
                        onchange=""FetchSelectedProjectStatuses()"" required>
");
#nullable restore
#line 27 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
                      
                        ProjectRepository projectRepository = new ProjectRepository();
                        foreach (Project project in projectRepository.GetAllProjects())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "148880db4f1971a3fe7e2c06064a29b434c0d3e16346", async() => {
#nullable restore
#line 31 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
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
#line 31 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
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
#line 32 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </select>\r\n\r\n                <label for=\"ttype\"><b>Select task type</b></label>\r\n                <select id=\"taskTypes\" name=\"taskTypes\" class=\"form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "148880db4f1971a3fe7e2c06064a29b434c0d3e18679", async() => {
                    WriteLiteral("Task type");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>

                <label for=""texpiration""><b>Finished until</b></label>
                <input type=""date"" class=""form-control"" placeholder=""Enter Task Finish Date"" name=""expectedEndDate"" required>

                <div class=""my-2""></div>
                <input class=""btn btn-primary"" type=""submit"" value=""Create"" />
                <input class=""btn btn-danger"" onclick=""window.location.href='/'"" type=""button"" value=""Cancel"" />
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
AddHtmlAttributeValue("", 832, Url.Action("CreateTask","Tasks"), 832, 33, false);

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

<!-- Task types options filler  & Summernote inclusion-->
<script type=""text/javascript"">

    // This function retireves the available Task Types for the currently selected Project.
    // The function is triggered on projectName change.
    function FetchSelectedProjectStatuses() {
        var projectNameSelect = document.getElementById(""projectName"");
        var projectName = projectNameSelect.value;

        AjaxCall('/Tasks/GetTaskTypes', null).done(function (response) {
            if (response.length > 0) {
                $('#taskTypes').html('');
                var options = '';
                for (var i = 0; i < response.length; i++) {
                    options += '<option name=""taskType"" value=""' + i + '"" text=""' + response[i] + '"">' + response[i] + '</option>';
                }
                $('#taskTypes').append(options);

            }
        }).fail(function (error) {
            alert(error.StatusText);
        });

     ");
            WriteLiteral(@"   function AjaxCall(url, data, type) {
            return $.ajax({
                url: url,
                type: type ? type : 'GET',
                data: { //TODO: Fix hardcoded values!! Make the data passed from the function call!
                    projectName: projectName //hardcoded call!
                },
                contentType: 'application/json'
            });
        }
    }

    $(function () {

        $(document).ready(function () {

            FetchSelectedProjectStatuses() //Retrieve the available Task types for the project appearing by default

            $('#summernote').summernote({
                placeholder: 'Task description...',
                tabsize: 1,
                height: 100
            });
        });
});
</script>

");
#nullable restore
#line 103 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Tasks\CreateTask.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
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
