#pragma checksum "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f538ab1f4702049acc0b82a3443abaabf71a12"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f538ab1f4702049acc0b82a3443abaabf71a12", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f582b379e209711f2143c0b1b9f95e968909e96b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, List<T_FORCE.Models.Task>>>
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
            WriteLiteral(" <!--Created by me Task card-->\r\n                                    <div class=\"card shadow mb-4\">\r\n                                        <!-- Card Header - Accordion -->\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 803, "\"", 843, 2);
            WriteAttributeValue("", 810, "#collapseCardCreatedTask-", 810, 25, true);
#nullable restore
#line 21 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 835, task.Id, 835, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block card-header py-3\" data-toggle=\"collapse\" role=\"button\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 936, "\"", 984, 2);
            WriteAttributeValue("", 952, "collapseCardCreatedTask-", 952, 24, true);
#nullable restore
#line 21 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 976, task.Id, 976, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h6 class=\"m-0 font-weight-bold text-primary\">");
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
            WriteLiteral("</h6>\r\n                                        </a>\r\n                                        <!-- Card Content - Collapse -->\r\n                                        <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1304, "\"", 1341, 2);
            WriteAttributeValue("", 1309, "collapseCardCreatedTask-", 1309, 24, true);
#nullable restore
#line 25 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 1333, task.Id, 1333, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1342, "\"", 1350, 0);
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
            WriteLiteral("</div>\r\n                                                        <label for=\"tassignee\"><b>Assignee</b></label>\r\n                                                        <p>");
#nullable restore
#line 32 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                      Write(task.GetAssigneeFirstLastName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <label for=\"tstatus\"><b>Status</b></label>\r\n                                                        <p>");
#nullable restore
#line 34 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                      Write(task.TaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <label for=\"tProject\"><b>Project</b></label>\r\n                                                        <p>");
#nullable restore
#line 36 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                      Write(projectRepository.GetProjectByCode(task.ProjectCode).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                    </div>
                                                    <div class=""col"">
                                                        <div class=""row"">
                                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2651, "\"", 2711, 3);
            WriteAttributeValue("", 2661, "window.location.href=\'/Tasks/ViewTask?id=", 2661, 41, true);
#nullable restore
#line 40 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 2702, task.Id, 2702, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2710, "\'", 2710, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-outline-primary"" style=""margin: 2%;"">Open</button>
                                                        </div>
                                                        <div class=""row"">
                                                            <button");
            BeginWriteAttribute("href", " href=\"", 3000, "\"", 3033, 2);
            WriteAttributeValue("", 3007, "/Tasks/Archive?id=", 3007, 18, true);
#nullable restore
#line 43 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 3025, task.Id, 3025, 8, false);

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
            WriteLiteral(" <!--Assigned Task card-->\r\n                                    <div class=\"card shadow mb-4\">\r\n                                        <!-- Card Header - Accordion -->\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3954, "\"", 3995, 2);
            WriteAttributeValue("", 3961, "#collapseCardAssignedTask-", 3961, 26, true);
#nullable restore
#line 60 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 3987, task.Id, 3987, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block card-header py-3\" data-toggle=\"collapse\" role=\"button\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 4088, "\"", 4137, 2);
            WriteAttributeValue("", 4104, "collapseCardAssignedTask-", 4104, 25, true);
#nullable restore
#line 60 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 4129, task.Id, 4129, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h6 class=\"m-0 font-weight-bold text-primary\">");
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
            WriteLiteral("</h6>\r\n                                        </a>\r\n                                        <!-- Card Content - Collapse -->\r\n                                        <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 4457, "\"", 4495, 2);
            WriteAttributeValue("", 4462, "collapseCardAssignedTask-", 4462, 25, true);
#nullable restore
#line 64 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 4487, task.Id, 4487, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 4496, "\"", 4504, 0);
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
            WriteLiteral("</div>\r\n                                                        <label for=\"tassignee\"><b>Assignee</b></label>\r\n                                                        <p>");
#nullable restore
#line 71 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                      Write(task.GetAssigneeFirstLastName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <label for=\"tstatus\"><b>Status</b></label>\r\n                                                        <p>");
#nullable restore
#line 73 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                      Write(task.TaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <label for=\"tProject\"><b>Project</b></label>\r\n                                                        <p>");
#nullable restore
#line 75 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
                                                      Write(projectRepository.GetProjectByCode(task.ProjectCode).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                    </div>
                                                    <div class=""col"">
                                                        <div class=""row"">
                                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 5805, "\"", 5865, 3);
            WriteAttributeValue("", 5815, "window.location.href=\'/Tasks/ViewTask?id=", 5815, 41, true);
#nullable restore
#line 79 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
WriteAttributeValue("", 5856, task.Id, 5856, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5864, "\'", 5864, 1, true);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89f538ab1f4702049acc0b82a3443abaabf71a1220773", async() => {
                WriteLiteral(@"

                <label for=""pName"">Project name</label>
                <input type=""text"" class=""form-control form-control-user""
                       id=""projectName"" name=""projectName"" placeholder=""Project name..."" required>

                <label for=""pName"">Project code</label>
                <input type=""text"" class=""form-control form-control-user""
                       id=""projectCode"" name=""projectCode"" placeholder=""Project code..."" required>


                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <input type=""submit"" class=""btn btn-primary"" value=""Save Changes"">
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
#line 115 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7737, Url.Action("CreateProject","Home"), 7737, 35, false);

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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 137 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Home\Index.cshtml"
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
