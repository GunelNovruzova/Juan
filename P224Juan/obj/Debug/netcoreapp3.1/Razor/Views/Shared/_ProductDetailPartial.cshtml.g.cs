#pragma checksum "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ce1436f3bf41aff841eb9b732d803cd7f0e9d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductDetailPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductDetailPartial.cshtml")]
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
#line 2 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\_ViewImports.cshtml"
using P224Juan.ViewModels.Contact;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ce1436f3bf41aff841eb9b732d803cd7f0e9d4", @"/Views/Shared/_ProductDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361ce6c6d1d5e0cb2a7fe166a3a6cb57596eb217", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ColorIds[]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectColor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "SizeIds[]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectSize"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("basketform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-header"">
    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
</div>
<div class=""modal-body"">
    <!-- product details inner end -->
    <div class=""product-details-inner"">
        <div class=""row"">
            <div class=""col-lg-5"">
                <div class=""product-large-slider mb-20"">
");
#nullable restore
#line 11 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                     foreach (ProductImage productImage in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"pro-large-img img-zoom\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 557, "\"", 601, 2);
            WriteAttributeValue("", 563, "assets/img/product/", 563, 19, true);
#nullable restore
#line 14 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
WriteAttributeValue("", 582, productImage.Image, 582, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product thumb\" />\r\n                        </div>\r\n");
#nullable restore
#line 16 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"pro-nav slick-row-5\">\r\n");
#nullable restore
#line 20 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                     foreach (ProductImage productImage in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"pro-nav-thumb\"><img");
            BeginWriteAttribute("src", " src=\"", 918, "\"", 962, 2);
            WriteAttributeValue("", 924, "assets/img/product/", 924, 19, true);
#nullable restore
#line 22 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
WriteAttributeValue("", 943, productImage.Image, 943, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 963, "\"", 969, 0);
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n            <div class=\"col-lg-7\">\r\n                <div class=\"product-details-des\">\r\n                    <h3 class=\"pro-det-title\">");
#nullable restore
#line 29 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"pro-review\">\r\n                        <span><a href=\"#\">1 Review(s)</a></span>\r\n                    </div>\r\n                    <div class=\"price-box\">\r\n");
#nullable restore
#line 34 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                         if (Model.DiscountPrice > 0)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"regular-price\">$");
#nullable restore
#line 37 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                                                    Write(Model.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"old-price\"><del>$");
#nullable restore
#line 38 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                                                     Write(Model.DiscountPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></span>\r\n");
#nullable restore
#line 39 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"regular-price\">$");
#nullable restore
#line 42 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                                                    Write(Model.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 43 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <p>");
#nullable restore
#line 46 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ce1436f3bf41aff841eb9b732d803cd7f0e9d413242", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group col-lg-4\">\r\n                            <label>Select Color</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ce1436f3bf41aff841eb9b732d803cd7f0e9d413651", async() => {
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 50 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = new SelectList(ViewBag.Colors, nameof(Color.Name), nameof(Color.Name));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <span class=\"text-danger\"></span>\r\n                        </div>\r\n\r\n                        <div class=\"form-group col-lg-4\">\r\n                            <label>Size</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ce1436f3bf41aff841eb9b732d803cd7f0e9d415844", async() => {
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 57 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = new SelectList(ViewBag.Sizes, nameof(Size.Name), nameof(Size.Name));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <span class=""text-danger""></span>
                        </div>
                        <div class=""quantity"">
                            <div class=""pro-qty""><input type=""text"" id=""productcount"" value=""1""></div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Shared\_ProductDetailPartial.cshtml"
                                                                                                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                      <button form=""basketform"" type=""submit"" id=""addbasketbtn"" class=""btn btn-default addToBasket"">Add To Cart</button>
                  
                    <div class=""availability mb-20"">
                        <h5 class=""cat-title"">Availability:</h5>
                        <span>In Stock</span>
                    </div>
                    <div class=""share-icon"">
                        <h5 class=""cat-title"">Share:</h5>
                        <a href=""#""><i class=""fa fa-facebook""></i></a>
                        <a href=""#""><i class=""fa fa-twitter""></i></a>
                        <a href=""#""><i class=""fa fa-pinterest""></i></a>
                        <a href=""#""><i class=""fa fa-google-plus""></i></a>
                    </div>
                </div>
            </div>
        </div>
        <!-- product details inner end -->
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
