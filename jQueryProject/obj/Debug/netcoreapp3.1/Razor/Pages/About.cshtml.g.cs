#pragma checksum "C:\Users\admin\source\repos\jQueryProject\jQueryProject\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e12e3e62e1ab7b6513f838b33baededaf2681271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(jQueryProject.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e12e3e62e1ab7b6513f838b33baededaf2681271", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec05ee89c9b76f7a380ca3bd0521620154311a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\source\repos\jQueryProject\jQueryProject\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        body {
            background-image: url(""/Images/BackgroundDoor.jpg"");
        }
    </style>
    <div class=""text-center maintext"">
        <h1 class=""display-4"">About</h1>
        <h5 id=""randomness"">Established in 2014 in another dimension, RealFakeDoors.com has been the go to place for all your fake door needs. Have you ever opened a door and actually went somewhere? Well RealFakeDoors.com has you covered. Don't even worry, don't give it a second though, don't even think twice about it. Leave with an arm of fake doors in your arms today!</h5>
    </div>
<button class=""bg-primary"" onclick=""randColor()"" id=""dragButton"">Randomness</button>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<jQueryProject.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<jQueryProject.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<jQueryProject.AboutModel>)PageContext?.ViewData;
        public jQueryProject.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
