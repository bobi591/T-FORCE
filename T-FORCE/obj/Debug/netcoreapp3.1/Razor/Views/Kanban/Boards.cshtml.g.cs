#pragma checksum "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7930ec8a3b4d28558bfb3396e60d40a655939148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kanban_Boards), @"mvc.1.0.view", @"/Views/Kanban/Boards.cshtml")]
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
#line 4 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
using T_FORCE.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7930ec8a3b4d28558bfb3396e60d40a655939148", @"/Views/Kanban/Boards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f582b379e209711f2143c0b1b9f95e968909e96b", @"/Views/_ViewImports.cshtml")]
    public class Views_Kanban_Boards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<T_FORCE.Models.KanbanBoard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
   ViewData["Title"] = "Boards"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div id=\"container\" style=\"padding: 2%\">\r\n    <h1 class=\"h3 mb-1 text-gray-800\">Kanban Boards</h1>\r\n    <p class=\"mb-4\">Defined Kanban Boards</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
      
        UserRepository userRepository = new UserRepository();
        foreach (T_FORCE.Models.KanbanBoard board in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
                   Write(board.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <label for=\"bcreationDate\"><b>Date of creation</b></label>\r\n                    <div>");
#nullable restore
#line 22 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
                    Write(board.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <label for=\"bcreationDate\"><b>Created by</b></label>\r\n                    <div>");
#nullable restore
#line 24 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
                    Write(userRepository.GetUserById(board.CreatedBy).GetFirstNameLastName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <a class=\"stretched-link\"");
            BeginWriteAttribute("href", " href=\"", 1061, "\"", 1086, 2);
            WriteAttributeValue("", 1068, "Board?id=", 1068, 9, true);
#nullable restore
#line 26 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
WriteAttributeValue("", 1077, board.Id, 1077, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Boby Waffles\Desktop\T-FORCE\T-FORCE\Views\Kanban\Boards.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<T_FORCE.Models.KanbanBoard>> Html { get; private set; }
    }
}
#pragma warning restore 1591