#pragma checksum "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "921708eef8adeb07e3ac5663c7270dc6988dc42d"
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
#nullable restore
#line 1 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\_ViewImports.cshtml"
using IssueTrackingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\_ViewImports.cshtml"
using IssueTrackingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"921708eef8adeb07e3ac5663c7270dc6988dc42d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9668616484a068b7b5e67a0f646fc389b1fc203a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IssueTrackingSystem.Models.IssueBase.Issue>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/dashboardstyle.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "921708eef8adeb07e3ac5663c7270dc6988dc42d4363", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 2 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""filter_container"">
            <span class=""filter_name"">Filter</span>
            <input type=""text"" id=""input"" class=""filter_input"">
            <a href=""/new"" class=""btn btn-new"" id=""new_issue"">New Issue</a>
        </div>
        <div class=""issuesContainer"" id=""issuesContainer"">

");
#nullable restore
#line 17 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {   

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"issue\">\r\n                <div class=\"issue_description\">\r\n");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
                     if(item.Status=="Closed"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ion-icon name=\"build-outline\" class=\"nav__icon closed\"></ion-icon>  \r\n");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
                    }
                    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ion-icon name=\"bug-outline\" class=\"nav__icon open\"></ion-icon>  \r\n");
#nullable restore
#line 26 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                    \r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1068, 2);
            WriteAttributeValue("", 1054, "issue/", 1054, 6, true);
#nullable restore
#line 29 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 1060, item.id, 1060, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"issue-title\"><span >");
#nullable restore
#line 29 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                </div>\r\n                <div class=\"issue_comments\">\r\n                    <ion-icon name=\"chatbox-outline\" class=\"nav__icon\" style=\"width: 20px;\"></ion-icon>\r\n                    <span class=\"comments_count\">");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
                                            Write(item.AllComments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
                  
                    TimeSpan Timepassed=DateTime.UtcNow.Subtract(item.CreatedAt);
                    var time="";
                    if(Timepassed.Days>0)
                    {
                        time=Timepassed.Days+" Days ago";
                    }
                    else if(Timepassed.Hours>0){
                        time=Timepassed.Hours+" Hours ago";
                    }
                    else if(Timepassed.Minutes>0){
                        time=Timepassed.Minutes+" Minutes ago";
                    } 
                    else{
                        time=Timepassed.Seconds+ " Seconds Ago";
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"time\">");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
                             Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("     \r\n        </div>\r\n\r\n        \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "921708eef8adeb07e3ac5663c7270dc6988dc42d11038", async() => {
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
            WriteLiteral(@"
<script>
    $(""#input"").on(""change keyup paste click"", function(){


    $.get(""filterIssue?name=""+$(this).val(), 
            function(data,status){
                console.log(data);
                $(""#issuesContainer"").html(data);

    });
});
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IssueTrackingSystem.Models.IssueBase.Issue>> Html { get; private set; }
    }
}
#pragma warning restore 1591
