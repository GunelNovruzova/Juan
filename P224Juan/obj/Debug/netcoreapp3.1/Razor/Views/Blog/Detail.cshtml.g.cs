#pragma checksum "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34689db8bec3ef979929eeeb68b689ff6c717b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f34689db8bec3ef979929eeeb68b689ff6c717b5", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361ce6c6d1d5e0cb2a7fe166a3a6cb57596eb217", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("widget-search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"" style=""background-image: url(&quot;assets/img/banner/breadcrumb-banner.jpg&quot;);"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">Blog</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item""><a href=""blog-right-sidebar.html"">Blog</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Blog Details</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </d");
            WriteLiteral(@"iv>
    </div>
    <!-- breadcrumb area end -->
    <!-- blog main wrapper start -->
    <div class=""blog-main-wrapper section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 order-2"">
                    <div class=""blog-widget-wrapper"">
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <div class=""blog-widget-img"">
                                <img src=""/assets/img/blog/11.jpg"" alt=""author thumb"">
                            </div>
                            <div class=""blog-author-title text-center"">
                                <h5>Erik Jhonson</h5>
                                <span>UI UX Designer</span>
                                <div class=""blog-widget-icon"">
                                    <a href=""#""><i class=""fa fa-facebook""></i></a>
                                    <a href=""#""><i class=""fa fa-twitter""></i></a>
         ");
            WriteLiteral(@"                           <a href=""#""><i class=""fa fa-vimeo""></i></a>
                                    <a href=""#""><i class=""fa fa-pinterest-p""></i></a>
                                </div>
                            </div>
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Search</h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f34689db8bec3ef979929eeeb68b689ff6c717b59109", async() => {
                WriteLiteral("\r\n                                <input placeholder=\"Search keyword\" type=\"text\" class=\"search-field\">\r\n                                <button type=\"submit\" class=\"search-btn\"><i class=\"fa fa-search\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Recent Posts</h4>
                            <ul class=""recent-posts-inner"">
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/90a4e690-3ac5-46ed-836a-81f7a624f1ef_202205040331547493_blog-1.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod");
            WriteLiteral(@" tempor incidid</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/fe300699-6562-4f09-b101-112bf47b8413_202205040342327008_blog-2.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""");
            WriteLiteral(@"recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/20e3f8d8-a7a4-40f4-a072-1bf2d9960101_202205040344049126_blog-3.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/3c7c31ce-ed2a-4f6a-a22c-9f5396f0a81a_202205080107485235_recent-02.jpg"" alt=""post thumb""></a>
     ");
            WriteLiteral(@"                               </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/9b24b036-100f-4a8a-a2c1-48a2d64add31_202205081132021035_blog-details-2.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""");
            WriteLiteral(@"><a href=""blog-details.html"">Bigger ipsum dolor sit amet consectetur adipisicing elit. Voluptate perferendis consequuntur illo aliquid nihil ad neque, debitis praesentium libero ullam asperiores exercitationem deserunt inventore facilis, officiis,</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/8cd61891-f277-46ed-a190-db6ef3ca2c09_202205081132556046_blog-3.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Bigger ipsum dolor sit amet consectetur adipisicing elit");
            WriteLiteral(@". Voluptsperiores exercitationem deserunt inventore facilis, officiis,</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/aeed1f9c-1b73-41e7-a6ed-90df8f966781_202205081133314688_11.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image""");
            WriteLiteral(@">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/eb0b8268-cee4-4aef-ad70-ecf4da2ac7f3_202205081133588800_blog-1.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/9c566262-8787-4420-b96b-2d68035d2ac8_202205081135148608_blog-details-1.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div clas");
            WriteLiteral(@"s=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor</a></h6>
                                    </div>
                                </li>
                                <li class=""recent-posts"">
                                    <div class=""recent-posts-image"">
                                        <a href=""blog-details.html""><img src=""/assets/img/blog/ef014eb7-d62e-46ea-8465-0411f2ed4733_202205081135488161_blog-4.jpg"" alt=""post thumb""></a>
                                    </div>
                                    <div class=""recent-posts-body"">
                                        <span class=""recent-posts-meta"">February  13,  2018</span>
                                        <h6 class=""recent-posts-title""><a href=""blog-details.html"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d");
            WriteLiteral(@"o eiusmod tempor incidid</a></h6>
                                    </div>
                                </li>


                            </ul>
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Categories</h4>
                            <ul class=""blog-categories"">
                                <li><a href=""blog-details.html"">Shoes</a><span>(20)</span></li>
                                <li><a href=""blog-details.html"">Fashion</a><span>(20)</span></li>
                                <li><a href=""blog-details.html"">Wallet</a><span>(20)</span></li>
                                <li><a href=""blog-details.html"">Life Style</a><span>(20)</span></li>
                                <li><a href=""blog-details.html"">Electronics</a><span>(20)</span></li>
                                <li><a href=""blog-");
            WriteLiteral(@"details.html"">Jewellery &amp; Cosmetics</a><span>(20)</span></li>

                            </ul>
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Tags</h4>
                            <div class=""blog-tag"">
                                <a href=""blog-details.html"">Juanaa</a>
                                <a href=""blog-details.html"">Adidas</a>
                                <a href=""blog-details.html"">Fashion</a>
                                <a href=""blog-details.html"">Shoes</a>
                                <a href=""blog-details.html"">Bags</a>
                                <a href=""blog-details.html"">Wallet</a>
                                <a href=""blog-details.html"">Jewellery</a>

                            </div>
                        </div>
                        <!-- widget ite");
            WriteLiteral(@"m end -->
                    </div>
                </div>
                <div class=""col-lg-9 order-1"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <!-- blog single item start -->
                            <div class=""blog-post-item"">
                                <div class=""blog-thumb"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 13560, "\"", 13595, 2);
            WriteAttributeValue("", 13566, "/assets/img/blog/", 13566, 17, true);
#nullable restore
#line 195 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 13583, Model.Image, 13583, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"blog thumb\">\r\n                                </div>\r\n                                <div class=\"blog-content blog-details\">\r\n                                    <h5 class=\"blog-title\">\r\n                                        ");
#nullable restore
#line 199 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                    <ul class=\"blog-meta\">\r\n                                        <li><span>By: </span>");
#nullable restore
#line 202 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                                        Write(Model.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</li>\r\n                                        <li><span>On: </span>");
#nullable restore
#line 203 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                                        Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 206 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                   Write(Model.Description.ToString().Substring(0,70));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                    <blockquote>
                                        <p>
                                            Quisque semper nunc vitae erat pellentesque, ac placerat arcu consectetur.
                                            venenatis elit ac ultrices convallis. Duis est nisi, tincidunt ac urna sed,
                                            cursus blandit lectus. In ullamcorper sit amet ligula ut eleifend. Proin
                                            dictum
                                            tempor ligula, ac feugiat metus. Sed finibus tortor eu scelerisque
                                            scelerisque.
                                        </p>
                                    </blockquote>
                                    <p>

                                        ");
#nullable restore
#line 220 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                   Write(Model.Description.ToString().Substring(70));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                            <!-- blog single item start -->
                            <!-- comment area start -->
                            <div class=""comment-section section-padding"">
                                <h5>03 Comment</h5>
                                <ul>
");
#nullable restore
#line 229 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                     foreach (Review review in Model.Reviews)
                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("<li>\r\n                                            <div class=\"author-avatar\">\r\n                                                <img src=\"/assets/img/blog/comment-icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 15929, "\"", 15935, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </div>\r\n                                            <div class=\"comment-body\">\r\n                                                <span class=\"reply-btn\"><a href=\"#\">Reply</a></span>\r\n");
#nullable restore
#line 239 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                                 if (User.Identity.IsAuthenticated && review.Name== User.Identity.Name)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"reply-btn\"><a href=\"#\">Change</a></span>\r\n");
#nullable restore
#line 242 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <h5 class=\"comment-author\">");
#nullable restore
#line 243 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                                                      Write(review.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                <div class=\"comment-post-date\">\r\n                                                    ");
#nullable restore
#line 245 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                               Write(review.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                                <p>\r\n                                                    ");
#nullable restore
#line 248 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                               Write(review.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 252 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                            </div>
                            <!-- comment area end -->
                            <!-- start blog comment box -->
                            <div class=""blog-comment-wrapper"">
                                <h5>Leave A Reply</h5>
                                <p>Email address will not be published. Required fields are marked *</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f34689db8bec3ef979929eeeb68b689ff6c717b529084", async() => {
                WriteLiteral(@"
                                    <div class=""comment-post-box"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <label>Comment</label>
                                                <textarea id=""Message"" name=""Message"" placeholder=""Write a comment""></textarea>
                                            </div>
                                            <div class=""col-12"">
                                                <div class=""coment-btn"">
                                                    <button class=""btn""  name=""submit"" value=""POST COMMENT""></button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 262 "C:\Users\User\Desktop\JuanPro\P224Juan\Views\Blog\Detail.cshtml"
                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["bid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["bid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <!-- start blog comment box -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- blog main wrapper end -->
</main>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591