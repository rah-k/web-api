#pragma checksum "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99476b4735bb50dfcf6a5a558b07a7c02345e19b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProduct), @"mvc.1.0.view", @"/Views/Product/GetProduct.cshtml")]
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
#line 1 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\_ViewImports.cshtml"
using ShoppingMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\_ViewImports.cshtml"
using ShoppingMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99476b4735bb50dfcf6a5a558b07a7c02345e19b", @"/Views/Product/GetProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf5cfa36c6635cd4591d6665efbf0c7cda5d34f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/NewFolder/NewFolder/ai.jfif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml"
  
    ViewData["Title"] = "GetProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1 style=\"margin-left:400px\"><u> Men\'s Collections</u></h1>\r\n\r\n\r\n<div class=\"container mt-4\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card p-3\">\r\n                    <div class=\"d-flex flex-row mb-1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99476b4735bb50dfcf6a5a558b07a7c02345e19b4634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        <div class=\"d-flex flex-column ml-2\"><span>");
#nullable restore
#line 20 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml"
                                                              Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"text-black-50\">");
#nullable restore
#line 20 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml"
                                                                                                                     Write(product.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"ratings\"><i class=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i class=\"fa fa-star\"></i></span></div>\r\n                    </div>\r\n                    <h6>");
#nullable restore
#line 22 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml"
                   Write(product.Descriptions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <div class=\"d-flex justify-content-between install mt-3\"><span> 172 Products</span><div class=\"btn-group\"><a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 968, 2);
            WriteAttributeValue("", 936, "/product/viewdetails/", 936, 21, true);
#nullable restore
#line 23 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 957, product.Id, 957, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a> &nbsp;<i class=\"fa fa-angle-right\"></i></div></div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\91852\source\repos\ShoppingMVC\ShoppingMVC\Views\Product\GetProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
