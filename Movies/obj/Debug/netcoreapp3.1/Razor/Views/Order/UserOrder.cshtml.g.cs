#pragma checksum "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae50473d059e6765b34f1cebe20ad4f2ce841189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_UserOrder), @"mvc.1.0.view", @"/Views/Order/UserOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae50473d059e6765b34f1cebe20ad4f2ce841189", @"/Views/Order/UserOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_UserOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies.Models.ViewModels.OrderListVM>
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
#line 2 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
  
    ViewData["Title"] = "Order List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae50473d059e6765b34f1cebe20ad4f2ce8411893509", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <hr />\r\n    <h3 class=\"text-center\">Order List</h3>\r\n");
            WriteLiteral("    <hr /> \r\n");
#nullable restore
#line 15 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
     if (Model.Orders.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table id=""orders"" class="" table table-bordered"" width=""100%"">
            <thead>
                <tr>
                    <th></th>

                    <th>Title</th>
                    <th>Buyer</th>
                    <th>Amount</th>

                    <th>Created</th>

                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 32 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
                 foreach (var ord in Model.Orders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><img style=\"width:100px;height:70px\"");
            BeginWriteAttribute("src", " src=\"", 1010, "\"", 1044, 2);
            WriteAttributeValue("", 1016, "/images/", 1016, 8, true);
#nullable restore
#line 35 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
WriteAttributeValue("", 1024, ord.Movie.ImagePath, 1024, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
            WriteLiteral("                    <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
               Write(ord.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
                   Write(ord.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 40 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
                    Write(ord.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
                   Write(ord.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 50 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
    }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"text-center\">No Data has been found</h5>\r\n");
#nullable restore
#line 54 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Order\UserOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies.Models.ViewModels.OrderListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
