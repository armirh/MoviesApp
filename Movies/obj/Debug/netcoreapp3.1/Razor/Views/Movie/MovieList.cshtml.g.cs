#pragma checksum "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7362ec0e5aa37c91582cfb2464755db1e10a4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieList), @"mvc.1.0.view", @"/Views/Movie/MovieList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7362ec0e5aa37c91582cfb2464755db1e10a4a", @"/Views/Movie/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies.Models.ViewModels.MoviesListVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info float-right m-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer; width:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
  
    ViewData["Title"] = "MovieList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f7362ec0e5aa37c91582cfb2464755db1e10a4a5348", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <hr />\r\n    <h1>Movies List</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f7362ec0e5aa37c91582cfb2464755db1e10a4a6491", async() => {
                WriteLiteral("<i class=\'fas fa-plus\'></i>Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <hr />
    <table id=""movies"" class="" table table-bordered"" width=""100%"">
        <thead>
            <tr>
                <th></th>
                <th>Genre</th>
                <th>Title</th>
                <th>Duration</th>
                <th>Year</th>
                <th>Rating</th>
                <th>Created</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
             if (Model.Movies.Any())
            {
                foreach (var gen in Model.Movies)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><img style=\"width:100px;height:70px\"");
            BeginWriteAttribute("src", " src=\"", 1077, "\"", 1105, 2);
            WriteAttributeValue("", 1083, "/images/", 1083, 8, true);
#nullable restore
#line 34 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
WriteAttributeValue("", 1091, gen.ImagePath, 1091, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                       Write(gen.Genre.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                       Write(gen.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                       Write(gen.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                       Write(gen.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                       Write(gen.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                       Write(gen.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f7362ec0e5aa37c91582cfb2464755db1e10a4a11321", async() => {
                WriteLiteral("<i class=\'far fa-edit\'></i>Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                                 WriteLiteral(gen.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            <a onclick=Delete(\"/Movie/Delete/");
#nullable restore
#line 47 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                                                        Write(gen.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\")\r\n\r\n                            class=\'btn btn-danger text-white\'\r\n                            style=\'cursor:pointer; width:100px;\'><i class=\'far fa-trash-alt\'></i>Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\miri-\OneDrive\Desktop\FIRST SEMSTER\SOFTWARE ENGEERING I\MID TERM PROJECT\Movies\Movies\Views\Movie\MovieList.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

</div>
<script>
    function Delete(url) {
        swal({
            title: ""Are you sure you want to delete?"",
            text: ""You will not be able to restore the content!"",
            type: ""warning"",
            showCancelButton: true,
            confirmButtonColor: ""#DD6B55"",
            confirmButtonText: ""Yes, delete it!"",
            closeOnconfirm: true
        }, function () {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        // dataTable.ajax.reload();
                        //window.location.href = data.redirectUrl;
                        setTimeout(function () {// wait for 5 secs(2)
                             location.reload(); // then reload the page.(3)
                           // window.location.href = data.redirectUrl;
                    ");
            WriteLiteral("    }, 3000);\r\n                    }\r\n                    else {\r\n                        toastr.error(data.message);\r\n                    }\r\n                }\r\n            });\r\n        });\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies.Models.ViewModels.MoviesListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591