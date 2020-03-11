#pragma checksum "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3606e8fca44a0903e6b0586494475715ab825bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3606e8fca44a0903e6b0586494475715ab825bf7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5248bf442f966f6e26cecfd77912423bda3fe926", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Lab05.Product>
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
#nullable restore
#line 1 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3606e8fca44a0903e6b0586494475715ab825bf73057", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Home</title>
    <style>
        steamboat {
            display: block;
            color: purple;
            background-color: limegreen;
            font-family: monospace;
        }
        .header {
            font-size: 50pt;
            font-weight: bold;
            color: red;
        }

        .container {
            margin: auto;
            padding: 10px 0 0 0;
            text-align: center;
            width: 60%;
            border: 1px solid black;
            background-color: lightgrey;
        }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3606e8fca44a0903e6b0586494475715ab825bf74656", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h1 class=\"header\">Content will go here</h1>\r\n        <h1 class=\"header\">My Mom\'s name is ");
#nullable restore
#line 35 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
                                       Write(ViewBag.Mom);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <p>Product Name: ");
#nullable restore
#line 36 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>Product Price: ");
#nullable restore
#line 37 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
                     Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>\r\n            Stock Level: \r\n");
#nullable restore
#line 40 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
             if (ViewBag.StockLevel ==0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral(" Out of Stock\r\n");
#nullable restore
#line 43 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
            }
            else if (ViewBag.StockLevel > 0 && ViewBag.StockLevel <= 3)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <b>Low Stock (");
#nullable restore
#line 46 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
                         Write(ViewBag.StockLevel);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</b>\r\n");
#nullable restore
#line 47 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
              Write(ViewBag.StockLevel);

#line default
#line hidden
#nullable disable
                WriteLiteral(" in Stock\r\n");
#nullable restore
#line 51 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <steamboat>\r\n            <p>");
#nullable restore
#line 55 "C:\Users\wwstudent\Documents\ISTA322\Labs\MVC-Lab05\Views\Home\Index.cshtml"
          Write(ViewBag.StockLevel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </steamboat>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Lab05.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
