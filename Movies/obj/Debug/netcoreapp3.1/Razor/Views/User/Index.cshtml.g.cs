#pragma checksum "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bda9716762fd0bcd69b52c43962f19af89cbbfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bda9716762fd0bcd69b52c43962f19af89cbbfe", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bda9716762fd0bcd69b52c43962f19af89cbbfe3466", async() => {
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n");
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <hr />\r\n    <h1>Order List</h1>\r\n");
            WriteLiteral(@"    <hr />
    <table id=""users"" class="" table table-bordered"" width=""100%"">
        <thead>
            <tr>
                <th>First Name</th>

                <th>Last Name</th>
                <th>Email</th>
                <th>Phone</th>

                <th>Address</th>
                
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
             if (Model.Count() > 0)
            {
                foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n               \r\n                <td>");
#nullable restore
#line 35 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
               Write(user.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
               Write(user.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
               Write(user.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
               Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\User\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591