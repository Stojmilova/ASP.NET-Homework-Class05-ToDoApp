#pragma checksum "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9dcb0c5406db655866f10f5b0751db5ac01a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_AddNewTask), @"mvc.1.0.view", @"/Views/Task/AddNewTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/AddNewTask.cshtml", typeof(AspNetCore.Views_Task_AddNewTask))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9dcb0c5406db655866f10f5b0751db5ac01a2a", @"/Views/Task/AddNewTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90288a6bb780fd33c56b5678062365e89bf39cd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_AddNewTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TasksViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
  
    ViewBag.Title = "Add New Task";

#line default
#line hidden
            BeginContext(67, 35, true);
            WriteLiteral("\r\n<h1 style=\"color:cornflowerblue\">");
            EndContext();
            BeginContext(103, 13, false);
#line 6 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                            Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(116, 77, true);
            WriteLiteral("</h1>\r\n\r\n<p>Please enter the correct data to add a new Task</p>\r\n\r\n<br />\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
 using (Html.BeginForm())
{

    

#line default
#line hidden
            BeginContext(230, 27, false);
#line 15 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                ;
    

#line default
#line hidden
            BeginContext(265, 29, false);
#line 16 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.TextBoxFor(x => x.Title));

#line default
#line hidden
            EndContext();
#line 16 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                  ;

#line default
#line hidden
            BeginContext(297, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(314, 33, false);
#line 18 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
#line 18 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                      ;
    

#line default
#line hidden
            BeginContext(355, 35, false);
#line 19 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.TextBoxFor(x => x.Description));

#line default
#line hidden
            EndContext();
#line 19 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                        ;

#line default
#line hidden
            BeginContext(393, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(410, 30, false);
#line 21 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.LabelFor(x => x.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(447, 87, false);
#line 22 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.DropDownListFor(x => x.Priority, Html.GetEnumSelectList(Model.Priority.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(536, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(553, 28, false);
#line 24 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.LabelFor(x => x.Status));

#line default
#line hidden
            EndContext();
            BeginContext(588, 83, false);
#line 25 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.DropDownListFor(x => x.Status, Html.GetEnumSelectList(Model.Status.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(673, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(690, 30, false);
#line 27 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.LabelFor(x => x.TaskType));

#line default
#line hidden
            EndContext();
            BeginContext(727, 87, false);
#line 28 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.DropDownListFor(x => x.TaskType, Html.GetEnumSelectList(Model.TaskType.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(816, 24, true);
            WriteLiteral("    <br />\r\n    <br />\r\n");
            EndContext();
            BeginContext(845, 34, false);
#line 31 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.LabelFor(x => x.TitleSubTask));

#line default
#line hidden
            EndContext();
#line 31 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                       ;
    

#line default
#line hidden
            BeginContext(887, 36, false);
#line 32 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.TextBoxFor(x => x.TitleSubTask));

#line default
#line hidden
            EndContext();
#line 32 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                         ;

#line default
#line hidden
            BeginContext(926, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(943, 40, false);
#line 34 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.LabelFor(x => x.DescriptionSubTask));

#line default
#line hidden
            EndContext();
#line 34 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                             ;
    

#line default
#line hidden
            BeginContext(991, 42, false);
#line 35 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.TextBoxFor(x => x.DescriptionSubTask));

#line default
#line hidden
            EndContext();
#line 35 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
                                               ;

#line default
#line hidden
            BeginContext(1036, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(1053, 95, false);
#line 37 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
Write(Html.DropDownListFor(x=>x.StatusSubTask, Html.GetEnumSelectList(Model.StatusSubTask.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 50, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    <button>ADD</button>\r\n");
            EndContext();
#line 41 "C:\Users\Stojmilova\Desktop\Homework - Class 05\ToDoApp\ToDoTasks\Views\Task\AddNewTask.cshtml"
}

#line default
#line hidden
            BeginContext(1203, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TasksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
