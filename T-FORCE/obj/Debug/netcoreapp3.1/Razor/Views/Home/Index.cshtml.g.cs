#pragma checksum "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f4642c6483a6a7e8292406016b05f505783e330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 4 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
using T_FORCE.UserInterfaceUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
using T_FORCE.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4642c6483a6a7e8292406016b05f505783e330", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f582b379e209711f2143c0b1b9f95e968909e96b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, List<T_FORCE.Models.Task>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("projectProperties"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
   ViewData["Title"] = "Dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<div id=\"container\" style=\"padding: 2%\">\r\n    <div class=\"row\">\r\n        <div class=\"col-5\">\r\n            <h1 class=\"h3 mb-1 text-gray-800\">Created Tasks</h1>\r\n            <p class=\"mb-4\">Tasks created by you</p>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
              
                ProjectRepository projectRepository = new ProjectRepository();
                foreach (T_FORCE.Models.Task task in Model[PredefinedViewBag.CreatedTasks])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Created by me Task card-->\r\n                    <div class=\"card shadow mb-4\">\r\n                        <!-- Card Header - Accordion -->\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 756, "\"", 796, 2);
            WriteAttributeValue("", 763, "#collapseCardCreatedTask-", 763, 25, true);
#nullable restore
#line 21 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 788, task.Id, 788, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block card-header py-3\" data-toggle=\"collapse\" role=\"button\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 889, "\"", 937, 2);
            WriteAttributeValue("", 905, "collapseCardCreatedTask-", 905, 24, true);
#nullable restore
#line 21 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 929, task.Id, 929, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h6 class=\"m-0 font-weight-bold text-primary\">");
#nullable restore
#line 22 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                                     Write(task.ProjectCode);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                                                      Write(task.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 22 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                                                                 Write(task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </a>\r\n                        <!-- Card Content - Collapse -->\r\n                        <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1193, "\"", 1230, 2);
            WriteAttributeValue("", 1198, "collapseCardCreatedTask-", 1198, 24, true);
#nullable restore
#line 25 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 1222, task.Id, 1222, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1231, "\"", 1239, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-10"">
                                        <label for=""tdescription""><b>Description</b></label>
                                        <div>");
#nullable restore
#line 30 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                        Write(Html.Raw(@task.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <label for=\"tassignee\"><b>Assignee</b></label>\r\n                                        <p>");
#nullable restore
#line 32 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                      Write(task.GetAssigneeFirstLastName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <label for=\"tstatus\"><b>Status</b></label>\r\n                                        <p>");
#nullable restore
#line 34 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                      Write(task.TaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <label for=\"tProject\"><b>Project</b></label>\r\n                                        <p>");
#nullable restore
#line 36 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                      Write(projectRepository.GetProjectByCode(task.ProjectCode).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"col\">\r\n                                        <div class=\"row\">\r\n                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2300, "\"", 2360, 3);
            WriteAttributeValue("", 2310, "window.location.href=\'/Tasks/ViewTask?id=", 2310, 41, true);
#nullable restore
#line 40 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 2351, task.Id, 2351, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2359, "\'", 2359, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\" style=\"margin: 2%;\">Open</button>\r\n                                        </div>\r\n                                        <div class=\"row\">\r\n                                            <button");
            BeginWriteAttribute("href", " href=\"", 2601, "\"", 2634, 2);
            WriteAttributeValue("", 2608, "/Tasks/Archive?id=", 2608, 18, true);
#nullable restore
#line 43 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 2626, task.Id, 2626, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" ype=""button"" class=""btn btn-outline-warning"" style=""margin: 2%;"">Archive</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div> ");
#nullable restore
#line 49 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                           } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-5\">\r\n            <h1 class=\"h3 mb-1 text-gray-800\">Assigned Tasks</h1>\r\n            <p class=\"mb-4\">Tasks assigned to you</p>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
              
                foreach (T_FORCE.Models.Task task in Model[PredefinedViewBag.AssignedTasks])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Assigned Task card-->\r\n                    <div class=\"card shadow mb-4\">\r\n                        <!-- Card Header - Accordion -->\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3411, "\"", 3452, 2);
            WriteAttributeValue("", 3418, "#collapseCardAssignedTask-", 3418, 26, true);
#nullable restore
#line 60 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 3444, task.Id, 3444, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block card-header py-3\" data-toggle=\"collapse\" role=\"button\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 3545, "\"", 3594, 2);
            WriteAttributeValue("", 3561, "collapseCardAssignedTask-", 3561, 25, true);
#nullable restore
#line 60 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 3586, task.Id, 3586, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h6 class=\"m-0 font-weight-bold text-primary\">");
#nullable restore
#line 61 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                                     Write(task.ProjectCode);

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                                                      Write(task.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 61 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                                                                 Write(task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </a>\r\n                        <!-- Card Content - Collapse -->\r\n                        <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 3850, "\"", 3888, 2);
            WriteAttributeValue("", 3855, "collapseCardAssignedTask-", 3855, 25, true);
#nullable restore
#line 64 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 3880, task.Id, 3880, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 3889, "\"", 3897, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-10"">
                                        <label for=""tdescription""><b>Description</b></label>
                                        <div>");
#nullable restore
#line 69 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                        Write(Html.Raw(@task.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <label for=\"tassignee\"><b>Assignee</b></label>\r\n                                        <p>");
#nullable restore
#line 71 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                      Write(task.GetAssigneeFirstLastName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <label for=\"tstatus\"><b>Status</b></label>\r\n                                        <p>");
#nullable restore
#line 73 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                      Write(task.TaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <label for=\"tProject\"><b>Project</b></label>\r\n                                        <p>");
#nullable restore
#line 75 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                      Write(projectRepository.GetProjectByCode(task.ProjectCode).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"col\">\r\n                                        <div class=\"row\">\r\n                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4958, "\"", 5018, 3);
            WriteAttributeValue("", 4968, "window.location.href=\'/Tasks/ViewTask?id=", 4968, 41, true);
#nullable restore
#line 79 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 5009, task.Id, 5009, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5017, "\'", 5017, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-outline-primary"" style=""margin: 2%;"">Open</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div> ");
#nullable restore
#line 85 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                           } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col\" style=\"margin-top: 6%; padding-left: 3%\">\r\n            <div class=\"row\">\r\n                <p>Tasks assigned to me: ");
#nullable restore
#line 89 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                    Write(Model[PredefinedViewBag.AssignedTasks].Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"row\">\r\n                <p>Tasks created by me: ");
#nullable restore
#line 92 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                   Write(Model[PredefinedViewBag.CreatedTasks].Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""row"">
                <button onclick=""window.location.href='/Tasks/CreateTask'"" type=""button"" class=""btn btn-outline-success"" style=""margin: 2%;"">Create task</button>
            </div>
            <div class=""row"">
                <button type=""button"" data-toggle=""modal"" data-target=""#createProjectModal"" class=""btn btn-outline-success"" style=""margin: 2%;"">Create project</button>
            </div>
        </div>
    </div>
</div>


<!-- Create project modal -->
<div class=""modal fade"" id=""createProjectModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Create new project</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;<");
            WriteLiteral("/span>\r\n                </button>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4642c6483a6a7e8292406016b05f505783e33019947", async() => {
                WriteLiteral(@"

                <label for=""pName"">Project name</label>
                <input type=""text"" class=""form-control form-control-user""
                       id=""projectName"" name=""projectName"" placeholder=""Project name..."" required>

                <label for=""pName"">Project code</label>
                <input type=""text"" class=""form-control form-control-user""
                       id=""projectCode"" name=""projectCode"" placeholder=""Project code..."" required>

                <label for=""pTaskStatus"">Task status</label>
                <input type=""text"" class=""form-control form-control-user""
                       id=""taskStatus"" name=""taskStatus"" placeholder=""Task status..."" required>


                <div class=""modal-footer"" id=""modalFooter"">
                    <input class=""btn btn-primary"" onclick=""GenerateTaskStatusInput()"" type=""button"" value=""Add Task status"" />
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                   ");
                WriteLiteral(" <input type=\"submit\" class=\"btn btn-success\" value=\"Save Changes\">\r\n                </div>\r\n            ");
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
#line 115 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6794, Url.Action("CreateProject","Home"), 6794, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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


<!-- Dynamic options menu for task status in Project creation -->
<script type=""text/javascript"">
    function GenerateTaskStatusInput() {
        var input = document.createElement(""input"");
        input.setAttribute('type', 'text');
        input.setAttribute('class', 'form-control form-control-user');
        input.setAttribute('placeholder', 'Task status...');
        input.setAttribute('name', 'taskStatus');
        input.setAttribute('required', '');

        var label = document.createElement(""label"");
        label.setAttribute('for', 'pTaskStatus');
        label.innerHTML = ""Task status"";

        var parent = document.getElementById(""projectProperties"");

        parent.insertBefore(label, parent.lastElementChild);
        parent.insertBefore(input, parent.lastElementChild);
    }
</script>

");
#nullable restore
#line 162 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, List<T_FORCE.Models.Task>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
