#pragma checksum "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f30fff9af58cf58737a2e8c4ce364b833442dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f30fff9af58cf58737a2e8c4ce364b833442dc", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"031039f11c04312ae737792757d5d83e9f171cb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberProfileVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main wrapper start -->
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">My Account</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">My Account</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- my account wrapper start -->
    <div class=""my-account-wrapper section-padding"">
        <div cla");
            WriteLiteral(@"ss=""container custom-container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- My Account Page Start -->
                    <div class=""myaccount-page-wrapper"">
                        <!-- My Account Tab Menu Start -->
                        <div class=""row"">
                            <div class=""col-lg-3 col-md-4"">
                                <div class=""myaccount-tab-menu nav"" role=""tablist"">

                                    <a href=""#orders"" data-toggle=""tab""><i class=""fa fa-cart-arrow-down""></i> Orders</a>


                                    <a href=""#account-info"" data-toggle=""tab""");
            BeginWriteAttribute("aria-selected", " aria-selected=\"", 1761, "\"", 1875, 1);
#nullable restore
#line 42 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml"
WriteAttributeValue("", 1777, (TempData["ProfileTab"] != null && TempData["ProfileTab"].ToString()=="Account"?"true":"false"), 1777, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1876, "\"", 1979, 1);
#nullable restore
#line 42 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml"
WriteAttributeValue("", 1884, (TempData["ProfileTab"] != null && TempData["ProfileTab"].ToString()=="Account"?"active":""), 1884, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i>  Account Details</a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f30fff9af58cf58737a2e8c4ce364b833442dc7585", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out\"></i> Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                            <!-- My Account Tab Menu End -->
                            <!-- My Account Tab Content Start -->
                            <div class=""col-lg-9 col-md-8"">
                                <div class=""tab-content"" id=""myaccountContent"">
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""orders"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Orders</h3>
                                            <div class=""myaccount-table table-responsive text-center"">
                                                <table class=""table table-bordered"">
                                                    <thead class=""thead-light"">
                                                        <tr>
                                            ");
            WriteLiteral(@"                <th>Order</th>
                                                            <th>Date</th>
                                                            <th>Status</th>
                                                            <th>Total</th>
                                                            <th>Action</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>1</td>
                                                            <td>Aug 22, 2018</td>
                                                            <td>Pending</td>
                                                            <td>$3000</td>
                                                            <td><a href=""cart.html"" class=""btn "">View</a></td>
                  ");
            WriteLiteral(@"                                      </tr>
                                                        <tr>
                                                            <td>2</td>
                                                            <td>July 22, 2018</td>
                                                            <td>Approved</td>
                                                            <td>$200</td>
                                                            <td><a href=""cart.html"" class=""btn "">View</a></td>
                                                        </tr>
                                                        <tr>
                                                            <td>3</td>
                                                            <td>June 12, 2017</td>
                                                            <td>On Hold</td>
                                                            <td>$990</td>
                                                            <");
            WriteLiteral(@"td><a href=""cart.html"" class=""btn "">View</a></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div");
            BeginWriteAttribute("class", " class=\"", 5785, "\"", 5905, 3);
            WriteAttributeValue("", 5793, "tab-pane", 5793, 8, true);
            WriteAttributeValue(" ", 5801, "fade", 5802, 5, true);
#nullable restore
#line 94 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml"
WriteAttributeValue(" ", 5806, (TempData["ProfileTab"]!=null && TempData["ProfileTab"].ToString()=="Account"?"active show":""), 5807, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"account-info\" role=\"tabpanel\">\r\n                                        <div class=\"myaccount-content\">\r\n                                            <h3>Account Details</h3>\r\n                                            ");
#nullable restore
#line 97 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml"
                                       Write(await Html.PartialAsync("_ProfileFormPartial", Model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div> <!-- Single Tab Content End -->
                                </div>
                            </div> <!-- My Account Tab Content End -->
                        </div>
                    </div> <!-- My Account Page End -->
                </div>
            </div>
        </div>
    </div>
    <!-- my account wrapper end -->
</main>
<!-- main wrapper end -->

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f30fff9af58cf58737a2e8c4ce364b833442dc14311", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out\"></i> Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                                </div>
                            </div>
<!-- My Account Tab Menu End -->
<!-- My Account Tab Content Start -->
<div class=""col-lg-9 col-md-8"">
    <div class=""tab-content"" id=""myaccountContent"">
        <!-- Single Tab Content Start -->
        <!-- Single Tab Content End -->
        <!-- Single Tab Content Start -->
        <div class=""tab-pane fade"" id=""orders"" role=""tabpanel"">
            <div class=""myaccount-content"">
                <h3>Orders</h3>
                <div class=""myaccount-table table-responsive text-center"">
                    <table class=""table table-bordered"">
                        <thead class=""thead-light"">
                            <tr>
                                <th>Order</th>
                                <th>Date</th>
                                <th>Status</th>
                                <th>Total</th>
                                <th>Action</th>
                            </tr>
                    ");
            WriteLiteral(@"    </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Aug 22, 2018</td>
                                <td>Pending</td>
                                <td>$3000</td>
                                <td><a href=""cart.html"" class=""btn "">View</a></td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>July 22, 2018</td>
                                <td>Approved</td>
                                <td>$200</td>
                                <td><a href=""cart.html"" class=""btn "">View</a></td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>June 12, 2017</td>
                                <td>On Hold</td>
                                <td>$990</td>
                                <td><a href=""");
            WriteLiteral(@"cart.html"" class=""btn "">View</a></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <!-- Single Tab Content End -->
        <!-- Single Tab Content Start -->
        <div class=""tab-pane fade"" id=""download"" role=""tabpanel"">
            <div class=""myaccount-content"">
                <h3>Downloads</h3>
                <div class=""myaccount-table table-responsive text-center"">
                    <table class=""table table-bordered"">
                        <thead class=""thead-light"">
                            <tr>
                                <th>Product</th>
                                <th>Date</th>
                                <th>Expire</th>
                                <th>Download</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Have");
            WriteLiteral(@"n - Free Real Estate PSD Template</td>
                                <td>Aug 22, 2018</td>
                                <td>Yes</td>
                                <td><a href=""#"" class=""btn ""><i class=""fa fa-cloud-download""></i> Download File</a></td>
                            </tr>
                            <tr>
                                <td>HasTech - Profolio Business Template</td>
                                <td>Sep 12, 2018</td>
                                <td>Never</td>
                                <td><a href=""#"" class=""btn ""><i class=""fa fa-cloud-download""></i> Download File</a></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <!-- Single Tab Content End -->
        <!-- Single Tab Content Start -->
        <div class=""tab-pane fade"" id=""payment-method"" role=""tabpanel"">
            <div class=""myaccount-content"">
                <h3>Payment");
            WriteLiteral(@" Method</h3>
                <p class=""saved-message"">You Can't Saved Your Payment Method yet.</p>
            </div>
        </div>
        <!-- Single Tab Content End -->
        <!-- Single Tab Content Start -->
        <div class=""tab-pane fade"" id=""address-edit"" role=""tabpanel"">
            <div class=""myaccount-content"">
                <h3>Billing Address</h3>
                <address>
                    <p><strong>Alex Tuntuni</strong></p>
                    <p>
                        1355 Market St, Suite 900 <br>
                        San Francisco, CA 94103
                    </p>
                    <p>Mobile: (123) 456-7890</p>
                </address>
                <a href=""#"" class=""check-btn sqr-btn ""><i class=""fa fa-edit""></i> Edit Address</a>
            </div>
        </div>
        <!-- Single Tab Content End -->
        <!-- Single Tab Content Start -->
        <div class=""tab-pane fade"" ");
#nullable restore
#line 222 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml"
                               Write((TempData["ProfileTab"] != null && TempData["ProfileTab"].ToString() == "Account" ? "active show" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" id=\"account-info\" role=\"tabpanel\">\r\n            <div class=\"myaccount-content\">\r\n                <h3>Account Details</h3>\r\n                <div class=\"account-details-form\">\r\n                    ");
#nullable restore
#line 226 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Account\Profile.cshtml"
               Write(await Html.PartialAsync("_ProfileFormPartial", Model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div> <!-- Single Tab Content End -->
    </div>
</div> <!-- My Account Tab Content End -->
                        </div>
                    </div> <!-- My Account Page End -->
                </div>
            </div>
        </div>
    </div>
<!-- my account wrapper end -->
</main>
<!-- main wrapper end -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberProfileVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
