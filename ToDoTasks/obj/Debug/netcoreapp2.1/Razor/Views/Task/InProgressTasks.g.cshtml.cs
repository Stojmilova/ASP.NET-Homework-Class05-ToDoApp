#pragma checksum "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5cf77927db42c082acedd02905d8844eb8e931e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_InProgressTasks), @"mvc.1.0.view", @"/Views/Task/InProgressTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/InProgressTasks.cshtml", typeof(AspNetCore.Views_Task_InProgressTasks))]
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
#line 1 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\_ViewImports.cshtml"
using ToDoTasks.Models.DomainModels;

#line default
#line hidden
#line 2 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\_ViewImports.cshtml"
using ToDoTasks.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\_ViewImports.cshtml"
using ToDoTasks.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5cf77927db42c082acedd02905d8844eb8e931e", @"/Views/Task/InProgressTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90288a6bb780fd33c56b5678062365e89bf39cd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_InProgressTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
  
    ViewBag.Title = "In Progress Tasks";

#line default
#line hidden
            BeginContext(62, 26, true);
            WriteLiteral("\r\n<h1 style =\"color:blue\">");
            EndContext();
            BeginContext(89, 13, false);
#line 6 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(102, 541, true);
            WriteLiteral(@"</h1>
<br />
<table style=""border:3px  double grey; width:100%; margin-bottom:10px; padding:5px"">
    <thead>
        <tr>
            <th style=""border:1px solid black"">Title</th>
            <th style=""border:1px solid black"">Description</th>
            <th style=""border:1px solid black"">Priority </th>
            <th style=""border:1px solid black"">Status</th>
            <th style=""border:1px solid black"">TaskType</th>
            <th style=""border:1px solid black"">SubTasks</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
         foreach (var task in Model.CreatedTasks)
        {
            if (task.Status == TypeStatus.InProgress)
            {

#line default
#line hidden
            BeginContext(775, 77, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(853, 10, false);
#line 25 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                                                  Write(task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(863, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(926, 16, false);
#line 26 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                                                  Write(task.Description);

#line default
#line hidden
            EndContext();
            BeginContext(942, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1005, 13, false);
#line 27 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                                                  Write(task.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1081, 11, false);
#line 28 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                                                  Write(task.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1155, 13, false);
#line 29 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                                                  Write(task.TaskType);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 94, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">\r\n                        <ul>\r\n");
            EndContext();
#line 32 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                             foreach (var subTask in task.SubTasks)
                            {

#line default
#line hidden
            BeginContext(1362, 43, true);
            WriteLiteral("                                <li>Title: ");
            EndContext();
            BeginContext(1406, 13, false);
#line 34 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                                      Write(subTask.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 17, true);
            WriteLiteral(" => Description: ");
            EndContext();
            BeginContext(1437, 19, false);
#line 34 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                                                                     Write(subTask.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 35 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
                            }

#line default
#line hidden
            BeginContext(1494, 81, true);
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\InProgressTasks.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1601, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
