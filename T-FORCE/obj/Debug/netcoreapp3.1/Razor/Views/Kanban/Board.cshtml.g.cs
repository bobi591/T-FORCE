#pragma checksum "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e53f59adb9bf485947164da8d47b2fc55a7db82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kanban_Board), @"mvc.1.0.view", @"/Views/Kanban/Board.cshtml")]
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
#line 2 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
using T_FORCE.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e53f59adb9bf485947164da8d47b2fc55a7db82", @"/Views/Kanban/Board.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f582b379e209711f2143c0b1b9f95e968909e96b", @"/Views/_ViewImports.cshtml")]
    public class Views_Kanban_Board : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KanbanBoard>
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
#line 4 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
   ViewData["Title"] = Model.Name; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"container\" style=\"padding: 2%\">\r\n    <h1 class=\"h4 mb-1 text-gray-800\" style=\"padding-bottom:1%;\">Kanban Board - ");
#nullable restore
#line 8 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
     if (Model.IsCustomBoard())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <button type=""button"" data-toggle=""modal"" data-target=""#addTaskModal"" class=""btn btn-outline-success"" style=""margin-right:0.5%;margin-bottom:1%;"">Add task</button>
        <button type=""button"" class=""btn btn-outline-danger"" style=""margin-right:1%;margin-bottom:1%;"">Remove task</button>
");
#nullable restore
#line 14 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 17 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
          
            TaskRepository taskRepository = new TaskRepository();

            for (int columnNumber = 0; columnNumber < Model.NumberOfColumns; columnNumber++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col border bg-light\"");
            BeginWriteAttribute("name", " name=\"", 844, "\"", 884, 1);
#nullable restore
#line 22 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 851, Model.GetColumns()[columnNumber], 851, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h1 class=\"h5 mb-1 text-gray-800 text-center\">");
#nullable restore
#line 23 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                             Write(Model.GetColumns()[columnNumber]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 24 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                      
                        List<T_FORCE.Models.Task> tasksInCurrentColumn = taskRepository.GetTasksInKanbanboardColumn(Model.Id, columnNumber + 1);

                        if (tasksInCurrentColumn != null)
                        {
                            foreach (T_FORCE.Models.Task task in tasksInCurrentColumn)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!--Task collapsable card-->\r\n                                <div class=\"card shadow mb-4\"");
            BeginWriteAttribute("name", " name=\"", 1494, "\"", 1526, 2);
#nullable restore
#line 32 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 1501, task.ProjectCode, 1501, 17, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 1518, task.Id, 1518, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <!-- Card Header - Accordion -->\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1638, "\"", 1678, 2);
            WriteAttributeValue("", 1645, "#collapseCardCreatedTask-", 1645, 25, true);
#nullable restore
#line 34 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 1670, task.Id, 1670, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block card-header py-3\" data-toggle=\"collapse\" role=\"button\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1771, "\"", 1819, 2);
            WriteAttributeValue("", 1787, "collapseCardCreatedTask-", 1787, 24, true);
#nullable restore
#line 34 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 1811, task.Id, 1811, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <h6 class=\"m-0 font-weight-bold text-primary\">");
#nullable restore
#line 35 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                                                 Write(task.ProjectCode);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                                                                  Write(task.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 35 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                                                                             Write(task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    </a>\r\n                                    <!-- Card Content - Collapse -->\r\n                                    <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 2123, "\"", 2160, 2);
            WriteAttributeValue("", 2128, "collapseCardCreatedTask-", 2128, 24, true);
#nullable restore
#line 38 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 2152, task.Id, 2152, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 2161, "\"", 2169, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col-10"">
                                                    <label for=""tdescription""><b>Description</b></label>
                                                    <div>");
#nullable restore
#line 43 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                    Write(Html.Raw(@task.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                    <label for=\"tassignee\"><b>Assignee</b></label>\r\n                                                    <p>");
#nullable restore
#line 45 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                  Write(task.GetAssigneeFirstLastName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <label for=\"tstatus\"><b>Status</b></label>\r\n                                                    <p>");
#nullable restore
#line 47 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                  Write(task.TaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                </div>
                                                <div class=""col"">
                                                    <div class=""row"">
                                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3193, "\"", 3257, 3);
            WriteAttributeValue("", 3203, "window.location.href=\'/Tasks/ViewTask?taskId=", 3203, 45, true);
#nullable restore
#line 51 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 3248, task.Id, 3248, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3256, "\'", 3256, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-outline-primary"" style=""margin: 2%;"">Open</button>
                                                    </div>
                                                    <div class=""row"">
                                                        <button");
            BeginWriteAttribute("href", " href=\"", 3534, "\"", 3567, 2);
            WriteAttributeValue("", 3541, "/Tasks/Archive?id=", 3541, 18, true);
#nullable restore
#line 54 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 3559, task.Id, 3559, 8, false);

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
                                </div>
");
#nullable restore
#line 61 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 66 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 72 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
 if (Model.IsCustomBoard())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Add task modal -->
    <div class=""modal fade"" id=""addTaskModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Add task to the dashboard</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e53f59adb9bf485947164da8d47b2fc55a7db8215279", async() => {
                WriteLiteral("\r\n                    <label for=\"taskId\">Board ID</label>\r\n                    <input type=\"text\" class=\"form-control form-control-user\"\r\n                           id=\"boardId\" name=\"boardId\"");
                BeginWriteAttribute("value", " value=\"", 5034, "\"", 5051, 1);
#nullable restore
#line 87 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
WriteAttributeValue("", 5042, Model.Id, 5042, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                    <label for=""taskId"">Task to add</label>
                    <input type=""text"" class=""form-control form-control-user""
                           id=""taskProjectCodeId"" name=""taskProjectCodeId"" placeholder=""Task Project Code ID (ex. MHN223)..."" required>
                    <label for=""columnSelector"">Column</label>
                    <select id=""columnDesc"" name=""columnDesc"" class=""form-control"" required>
");
#nullable restore
#line 93 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                          
                            foreach (string column in Model.GetColumns())
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e53f59adb9bf485947164da8d47b2fc55a7db8216930", async() => {
#nullable restore
#line 96 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                                   Write(column);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                                   WriteLiteral(column);

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
#line 97 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </select>
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
#line 84 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
AddHtmlAttributeValue("", 4799, Url.Action("TaskColumnSwitch","Kanban"), 4799, 40, false);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 109 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>

<script>
    //JQuery DragNDrop settings

    $(document).ready(function () {

        $("".card"").draggable({
            revert: ""invalid"", // when not dropped, the item will revert back to its initial position});
            stack: "".card""
        })

        $("".col"").droppable({
            appendTo: ""body"",
            drop: function (event, ui) {
                // do something with the dock
                var columnName = $(this).attr('name');
                // do something with the draggable item
                var cardName = $(ui.draggable).attr('name');
                var boardId = ");
#nullable restore
#line 133 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Board.cshtml"
                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

                        $.ajax({
                            type: ""POST"",
                            url: ""/Kanban/TaskColumnSwitch"",
                            data: { taskProjectCodeId: cardName, boardId: boardId, columnDesc: columnName },
                            dataType: ""text"",
                            success: function (msg) {
                                console.log(msg);
                                location.reload();
                            },
                            error: function (req, status, error) {
                                console.log(msg);
                            }
                        });
            }
        });

    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KanbanBoard> Html { get; private set; }
    }
}
#pragma warning restore 1591
