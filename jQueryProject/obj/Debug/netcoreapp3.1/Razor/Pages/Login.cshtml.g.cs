#pragma checksum "C:\Users\admin\source\repos\jQueryProject\jQueryProject\Pages\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec8c67e1734fe70e55ba52bcae6d246ccf0351f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(jQueryProject.Pages.Pages_Login), @"mvc.1.0.razor-page", @"/Pages/Login.cshtml")]
namespace jQueryProject.Pages
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
#line 1 "C:\Users\admin\source\repos\jQueryProject\jQueryProject\Pages\_ViewImports.cshtml"
using jQueryProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8c67e1734fe70e55ba52bcae6d246ccf0351f3", @"/Pages/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec05ee89c9b76f7a380ca3bd0521620154311a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\source\repos\jQueryProject\jQueryProject\Pages\Login.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <style>
        body {
            margin-bottom: 10px;
            background-image: url(""/Images/BackgroundDoor.jpg"");
        }
       
    </style>

<div class=""text-center maintext"">
    <h1 class=""display-4"">Login</h1>
    
</div>


<div class=""clear1"">
    <div class=""text-left"">
        <div class=""jumbotron"">
            <input placeholder=""Username"" type=""text"" name=""username"" id=""username"" /><br />
            <input placeholder=""Password"" type=""password"" name=""password"" id=""password"" /><br />

            <div><button onclick=""doLogin()"" name=""btnConnect"" id=""btnConnect"">Login</button></div>

        </div>

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<jQueryProject.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<jQueryProject.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<jQueryProject.CartModel>)PageContext?.ViewData;
        public jQueryProject.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
