#pragma checksum "E:\CNPM\AppbBaBau\app_pregnant\Pred\Views\Home\food.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ea777e21bae80562d30394e5b631b77b970330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_food), @"mvc.1.0.view", @"/Views/Home/food.cshtml")]
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
#line 1 "E:\CNPM\AppbBaBau\app_pregnant\Pred\Views\_ViewImports.cshtml"
using Pred;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CNPM\AppbBaBau\app_pregnant\Pred\Views\_ViewImports.cshtml"
using Pred.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ea777e21bae80562d30394e5b631b77b970330", @"/Views/Home/food.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbdeba141ca46c95cd3aa142bee253e3640304af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_food : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Nutrition.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\CNPM\AppbBaBau\app_pregnant\Pred\Views\Home\food.cshtml"
  
    ViewData["Title"] = "Thucdon";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ea777e21bae80562d30394e5b631b77b9703304146", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4ea777e21bae80562d30394e5b631b77b9703304408", async() => {
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
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ea777e21bae80562d30394e5b631b77b9703306290", async() => {
                WriteLiteral(@"
    <div class=""wrap"">
        <div class=""dudoan"">
            <h1>Thông tin dinh dưỡng theo số tuổi thai nhi</h1>
        </div>
        <div class=""tinhtoan"">
            <p>Nhập số ngày thai:  <input class=""input-text"" type=""text"" id=""test"" value=0></p>

            <button class=""btn-abouts"" href=""#"" ; onclick=""aboutuspage();"">Tính toán</button>
            </br>

        </div>
        <div class=""day-birth"">
            Dự đoán số ngày thai nhi ra đời: <p class=""doan""></p>
        </div>
        <div style=""width:100%;height:100%"" class=""trangchu"" id=""aboutus""></div>
    </div>
  

    <script>
    $(document).ready(function () {

        $('.btn-abouts').click(function () {
            if ($(""#test"").val() <= 280 && $(""#test"").val() > 0) {
                var time = 280 - $(""#test"").val();
                var month = Math.floor(time / 30);
                var day = time % 30;
                if (time >= 190) {
                    $("".doan"").empty();
                    $(");
                WriteLiteral("\".doan\").append(month + \" tháng\" + \" \" + day + \" ngày\");\r\n                    $(\'#aboutus\').load(\'");
#nullable restore
#line 37 "E:\CNPM\AppbBaBau\app_pregnant\Pred\Views\Home\food.cshtml"
                                   Write(Url.Action("thaidau","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n\r\n\r\n                } else if (time < 190 && time >= 100) {\r\n                    $(\".doan\").empty();\r\n                    $(\".doan\").append(month + \" tháng\" + \" \" + day + \" ngày\");\r\n                    $(\'#aboutus\').load(\'");
#nullable restore
#line 43 "E:\CNPM\AppbBaBau\app_pregnant\Pred\Views\Home\food.cshtml"
                                   Write(Url.Action("thaigiua","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n                } else {\r\n                    $(\".doan\").empty();\r\n                    $(\".doan\").append(month + \" tháng\" + \" \" + day + \" ngày\");\r\n                    $(\'#aboutus\').load(\'");
#nullable restore
#line 47 "E:\CNPM\AppbBaBau\app_pregnant\Pred\Views\Home\food.cshtml"
                                   Write(Url.Action("thaicuoi","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n                }\r\n            } else {\r\n                $(\".doan\").empty();\r\n                $(\".doan\").append(\"giá trị không phù hợp \");\r\n            }\r\n\r\n        });\r\n\r\n     });\r\n    </script>\r\n");
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
            WriteLiteral("\r\n\r\n");
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
