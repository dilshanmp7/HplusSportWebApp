#pragma checksum "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ac60e2a2cd97b6ca3b9960b0a5798e17cfd85d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\_ViewImports.cshtml"
using HPlusSportsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\_ViewImports.cshtml"
using HPlusSportsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ac60e2a2cd97b6ca3b9960b0a5798e17cfd85d", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d9b2d36eb5893f857a8d9ced006e6f6b501a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Newtonsoft.Json.Linq.JObject>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = Model["name"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"default\">\r\n    <div class=\"product-detail\">\r\n        <img class=\"product-image\"");
            BeginWriteAttribute("src", " src=\"", 183, "\"", 215, 1);
#nullable restore
#line 9 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
WriteAttributeValue("", 189, Model["image"].ToString(), 189, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 216, "\"", 247, 1);
#nullable restore
#line 9 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
WriteAttributeValue("", 222, Model["name"].ToString(), 222, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div>\r\n            <h2 class=\"product-name\">");
#nullable restore
#line 11 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                                Write(Model["name"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <p class=\"product-description\">");
#nullable restore
#line 13 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                                      Write(Model["description"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"product-size\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82ac60e2a2cd97b6ca3b9960b0a5798e17cfd85d5600", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                     if (Model.ContainsKey("sizes"))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                         foreach (var size in Model["sizes"])
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label><input type=\"radio\" name=\"size\"");
                BeginWriteAttribute("value", " value=\"", 717, "\"", 730, 1);
#nullable restore
#line 20 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
WriteAttributeValue("", 725, size, 725, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 20 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                                                                              Write(size);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 21 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\" name=\"size\"");
                BeginWriteAttribute("value", " value=\"", 904, "\"", 912, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 26 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <button class=\"btn-primary pull-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1036, "\"", 1113, 7);
            WriteAttributeValue("", 1046, "addToCart(\'", 1046, 11, true);
#nullable restore
#line 29 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1057, Model["id"].ToString(), 1057, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1080, "\',", 1080, 2, true);
            WriteAttributeValue(" ", 1082, "\'", 1083, 2, true);
#nullable restore
#line 29 "C:\Users\dper\Desktop\LinkedIn\Azure\Deploy Azure Site\HPlusSportsWeb\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1084, Model["name"].ToString(), 1084, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1109, "\'", 1109, 1, true);
            WriteAttributeValue(" ", 1110, ");", 1111, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Add to cart</button>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82ac60e2a2cd97b6ca3b9960b0a5798e17cfd85d10312", async() => {
                WriteLiteral("Back to Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Newtonsoft.Json.Linq.JObject> Html { get; private set; }
    }
}
#pragma warning restore 1591
