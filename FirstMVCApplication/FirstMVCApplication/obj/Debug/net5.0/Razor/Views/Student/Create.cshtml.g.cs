#pragma checksum "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3022456fcadd310287e89b8f2ab12e1d99c159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Create), @"mvc.1.0.view", @"/Views/Student/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c3022456fcadd310287e89b8f2ab12e1d99c159", @"/Views/Student/Create.cshtml")]
    public class Views_Student_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstMVCApplication.Models.Student>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c3022456fcadd310287e89b8f2ab12e1d99c1592989", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Create</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c3022456fcadd310287e89b8f2ab12e1d99c1594049", async() => {
                WriteLiteral("\r\n\r\n<h4>Student</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 20 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
       using (Html.BeginForm("Create", "Student", FormMethod.Post))
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            <div class=\"form-group\">\r\n              ");
#nullable restore
#line 24 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
         Write(Html.LabelFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 25 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
           Write(Html.EditorFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <span asp-validation-for=\"Id\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 29 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
           Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 30 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
           Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <span asp-validation-for=\"Name\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 34 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
           Write(Html.LabelFor(m => m.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 35 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
           Write(Html.EditorFor(m => m.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <span asp-validation-for=\"Age\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 41 "D:\MvcApplication\FirstMVCApplication\FirstMVCApplication\Views\Student\Create.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n      \r\n\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstMVCApplication.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
