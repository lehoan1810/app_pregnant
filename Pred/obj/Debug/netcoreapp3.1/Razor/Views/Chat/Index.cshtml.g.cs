#pragma checksum "T:\app_pregnant\Pred\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d85ee5c49e35a652843fdc8abf5566a5ec3e2e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#line 1 "T:\app_pregnant\Pred\Views\_ViewImports.cshtml"
using Pred;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
using Pred.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d85ee5c49e35a652843fdc8abf5566a5ec3e2e5", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbdeba141ca46c95cd3aa142bee253e3640304af", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/userdefault/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container\" style=\"min-height: 50vh\">\r\n    <div class=\"row\">\r\n        <div class=\"col-3 users-chat overflow-auto\">\r\n");
#nullable restore
#line 9 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
             foreach (var user in Model)
            {
                if (user.Id != SignInManager.UserManager.GetUserId(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row justify-content-between flex-row align-items-center chat-user\" >\r\n");
#nullable restore
#line 14 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
                         if (user.ProfilePicture != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"user-profile-picture-container\">\r\n                                <img");
            BeginWriteAttribute("id", " id=\"", 721, "\"", 734, 1);
#nullable restore
#line 17 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
WriteAttributeValue("", 726, user.Id, 726, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"profile-pic\"");
            BeginWriteAttribute("src", " src=\"", 755, "\"", 827, 2);
            WriteAttributeValue("", 761, "data:image/*;base64,", 761, 20, true);
#nullable restore
#line 17 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
WriteAttributeValue("", 781, Convert.ToBase64String(user.ProfilePicture), 781, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n");
#nullable restore
#line 19 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 985, "\"", 993, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d85ee5c49e35a652843fdc8abf5566a5ec3e2e56773", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
AddHtmlAttributeValue("", 1038, user.Id, 1038, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 25 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1200, "\"", 1208, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1209, "\"", 1244, 3);
            WriteAttributeValue("", 1219, "setChatToUser(\'", 1219, 15, true);
#nullable restore
#line 26 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
WriteAttributeValue("", 1234, user.Id, 1234, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1242, "\')", 1242, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
                                                                     Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <button class=\"btn\" onclick=\"alert(\'info Bác sĩ\')\">\r\n                            <i class=\"fa fa-info\" aria-hidden=\"true\"></i>\r\n                        </button>\r\n                    </div>\r\n");
#nullable restore
#line 31 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"col-8 d-flex flex-column\"   >\r\n            <input type=\"text\" class=\"w-100\" id=\"username\"");
            BeginWriteAttribute("value", " value=\"", 1640, "\"", 1667, 1);
#nullable restore
#line 36 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
WriteAttributeValue("", 1648, User.Identity.Name, 1648, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("userid", " userid=\"", 1668, "\"", 1719, 1);
#nullable restore
#line 36 "T:\app_pregnant\Pred\Views\Chat\Index.cshtml"
WriteAttributeValue("", 1677, SignInManager.UserManager.GetUserId(User), 1677, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled hidden />
            <input type=""text"" id=""users-tb"" name=""users"" disabled hidden />
                <div id=""chatting-user""></div>
                <ul class=""overflow-auto h-75 message-list"" id=""messagesList""></ul>
                <div>
                    <div class=""d-flex p-1 m-1"">
                        <input class=""w-100 m-1 form-control"" style=""border-radius:500px"" type=""text"" id=""messageInput""/>
                        <input type=""button"" class=""btn btn-primary m-1"" style=""border-radius:500px"" id=""sendButton"" value=""Gửi"" />
                    </div>
                </div>
        </div>
    </div>
</div>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d85ee5c49e35a652843fdc8abf5566a5ec3e2e511407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d85ee5c49e35a652843fdc8abf5566a5ec3e2e512447", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    .message {
        color:white;
        display: inline-block;
        list-style-type: none;
        position: relative;
        line-height: 3em;
        margin-left: 1em;
        margin-top: 1em;
        border-radius: 999vw;
        background: #757575;
        padding-left: 1em;
        padding-right: 1em;
    }

    .sender {
        list-style-type: none;
        position: relative;
        line-height: 3em;
        margin-right: 1em;
        margin-top: 1em;
        padding-left: 1em;
        padding-right: 1em;
        border-radius: 999vw;
        text-align: right;
    }

    .profile-pic {
        width: 3em;
        height: 3em;
        border-radius: 50%;
        overflow: hidden;
        margin: 1em;
    }

    .chat-user {
        border-bottom: solid 1px #E5E5E5;
        margin-right: 1em
    }

    .users-chat {
        border-right: solid 1px #E5E5E5;
        margin-bottom: 1em;
        margin-top: 1em
    }

    .message-list {");
            WriteLiteral("\n        border: solid 1px #E5E5E5;\r\n        margin: 1em;\r\n        border-radius: 1em;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
