#pragma checksum "C:\Users\HP\source\repos\MembersManager\MembersManager.Web\Pages\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "198569e3f3a1f35a61b2a9a3441ef06e2a420a3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MembersManager.Web.Pages.Home.Pages_Home_Index), @"mvc.1.0.view", @"/Pages/Home/Index.cshtml")]
namespace MembersManager.Web.Pages.Home
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
#line 1 "C:\Users\HP\source\repos\MembersManager\MembersManager.Web\Pages\_ViewImports.cshtml"
using MembersManager.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198569e3f3a1f35a61b2a9a3441ef06e2a420a3c", @"/Pages/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2400ad2649cfd6e545224a9989b2a54e625d905c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "198569e3f3a1f35a61b2a9a3441ef06e2a420a3c3773", async() => {
                WriteLiteral(@"
    <title>Login V2</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--===============================================================================================-->
    <link rel=""icon"" type=""image/png"" href=""loginForm/Login_v2/images/icons/favicon.ico"" />
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/vendor/bootstrap/css/bootstrap.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/fonts/iconic/css/material-design-iconic-font.min.css"">
    <!--===");
                WriteLiteral(@"============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/vendor/animate/animate.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/vendor/css-hamburgers/hamburgers.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/vendor/animsition/css/animsition.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/vendor/select2/select2.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/ven");
                WriteLiteral(@"dor/daterangepicker/daterangepicker.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""loginForm/Login_v2/css/main.css"">
    <!--===============================================================================================-->
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "198569e3f3a1f35a61b2a9a3441ef06e2a420a3c7355", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"limiter\">\r\n        <div class=\"container-login100\">\r\n            <div class=\"wrap-login100\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "198569e3f3a1f35a61b2a9a3441ef06e2a420a3c7755", async() => {
                    WriteLiteral(@"
                    <span class=""login100-form-title p-b-26"">
                        Welcome
                    </span>
                    <span class=""login100-form-title p-b-48"">
                        <i class=""zmdi zmdi-font""></i>
                    </span>

                    <div class=""wrap-input100 validate-input"" data-validate=""Valid email is: a@b.c"">
                        <input class=""input100"" type=""text"" name=""email"">
                        <span class=""focus-input100"" data-placeholder=""Email""></span>
                    </div>

                    <div class=""wrap-input100 validate-input"" data-validate=""Enter password"">
                        <span class=""btn-show-pass"">
                            <i class=""zmdi zmdi-eye""></i>
                        </span>
                        <input class=""input100"" type=""password"" name=""pass"">
                        <span class=""focus-input100"" data-placeholder=""Password""></span>
                    </div>

              ");
                    WriteLiteral(@"      <div class=""container-login100-form-btn"">
                        <div class=""wrap-login100-form-btn"">
                            <div class=""login100-form-bgbtn""></div>
                            <button class=""login100-form-btn"">
                                Login
                            </button>
                        </div>
                    </div>

                    <div class=""text-center p-t-115"">
                        <span class=""txt1"">
                            Don’t have an account?
                        </span>

                        <a class=""txt2"" href=""#"">
                            Sign Up
                        </a>
                    </div>
                ");
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
        </div>
    </div>


    <div id=""dropDownSelect1""></div>

    <!--===============================================================================================-->
    <script src=""loginForm/Login_v2/vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""loginForm/Login_v2/vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""loginForm/Login_v2/vendor/bootstrap/js/popper.js""></script>
    <script src=""loginForm/Login_v2/vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""loginForm/Login_v2/vendor/select2/select2.min.js""></script>
    <!--================================================================================");
                WriteLiteral(@"===============-->
    <script src=""loginForm/Login_v2/vendor/daterangepicker/moment.min.js""></script>
    <script src=""loginForm/Login_v2/vendor/daterangepicker/daterangepicker.js""></script>
    <!--===============================================================================================-->
    <script src=""loginForm/Login_v2/vendor/countdowntime/countdowntime.js""></script>
    <!--===============================================================================================-->
    <script src=""loginForm/Login_v2/js/main.js""></script>

");
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
            WriteLiteral("\r\n</html>");
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
