#pragma checksum "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f922ffd3e149a992d7ff06e4c327caf0f2a90da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IssueDetails), @"mvc.1.0.view", @"/Views/Home/IssueDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f922ffd3e149a992d7ff06e4c327caf0f2a90da", @"/Views/Home/IssueDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9668616484a068b7b5e67a0f646fc389b1fc203a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IssueDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IssueTrackingSystem.Models.IssueBase.Comments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/issuedetails.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("issue_description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Leave a comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/newComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment_model"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/issuedetail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1f922ffd3e149a992d7ff06e4c327caf0f2a90da7814", async() => {
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
            WriteLiteral("\r\n<div class=\"issue_info\">\r\n      <div class=\"first_row\">\r\n        <div class=\"issue_title\">\r\n          ");
#nullable restore
#line 11 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
     Write(ViewBag.Issue.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <a href=\"/new\" class=\"btn-new\" id=\"new_issue\">New Issue</a>\r\n      </div>\r\n      <div class=\"second_row\">\r\n");
#nullable restore
#line 17 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
         if(@ViewBag.Issue.Status=="Closed"){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ion-icon identify=\"Closed\" id=\"Closed\" name=\"build-outline\" class=\"nav__icon Closed\"></ion-icon> \r\n");
#nullable restore
#line 19 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
            }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ion-icon  id=\"Open\" identify=\"Open\" name=\"bug-outline\" class=\"nav__icon Open\"></ion-icon> \r\n");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
          
                    TimeSpan Timepassed=DateTime.UtcNow.Subtract(@ViewBag.Issue.CreatedAt);
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
            WriteLiteral("        <div class=\"time_passed_since_posted\"> ");
#nullable restore
#line 41 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
                                          Write(ViewBag.Issue.Host.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Opened this issue ");
#nullable restore
#line 41 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
                                                                                          Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n      </div>\r\n</div>\r\n\r\n<div class=\"helpful_info_issue\">\r\n  <div class=\"comments\">\r\n    <div class=\"comment_model\">\r\n          <img\r\n            class=\"profile\"");
            BeginWriteAttribute("src", "\r\n            src=\"", 1728, "\"", 1809, 2);
            WriteAttributeValue("", 1747, "https://ui-avatars.com/api/?name=", 1747, 33, true);
#nullable restore
#line 50 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
WriteAttributeValue("", 1780, ViewBag.Issue.Host.FirstName, 1780, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n            alt=\"", 1810, "\"", 1829, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n          />\r\n          <div class=\"comment_container\">\r\n            <div class=\"name\">");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
                         Write(ViewBag.Issue.Host.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> Author</span></div>\r\n            <div class=\"message\">\r\n              ");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
         Write(ViewBag.Issue.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n          </div>\r\n    </div> \r\n    \r\n\r\n\r\n");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
        foreach (var item in @ViewBag.Issue.AllComments)
       {
           
       

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"comment_model\">\r\n          <img\r\n            class=\"profile\"");
            BeginWriteAttribute("src", "\r\n            src=\"", 2285, "\"", 2357, 2);
            WriteAttributeValue("", 2304, "https://ui-avatars.com/api/?name=", 2304, 33, true);
#nullable restore
#line 70 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
WriteAttributeValue("", 2337, item.Host.FirstName, 2337, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n            alt=\"", 2358, "\"", 2377, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n          />\r\n          <div class=\"comment_container\">\r\n");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
              
                    Timepassed=DateTime.UtcNow.Subtract(@item.CreatedAt);
                    time="";
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
            WriteLiteral("            <div class=\"name\">");
#nullable restore
#line 91 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
                         Write(item.Host.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Posted ");
#nullable restore
#line 91 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
                                                           Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            <div class=\"message\">\r\n              ");
#nullable restore
#line 93 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
         Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(" \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f922ffd3e149a992d7ff06e4c327caf0f2a90da16678", async() => {
                WriteLiteral("\r\n            <img\r\n                class=\"profile\"");
                BeginWriteAttribute("src", "\r\n                src=\"", 3514, "\"", 3583, 2);
                WriteAttributeValue("", 3537, "https://ui-avatars.com/api/?name=", 3537, 33, true);
#nullable restore
#line 104 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
WriteAttributeValue("", 3570, ViewBag.Name, 3570, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                alt=""ProfilePic""
            />

            <div class=""comment_container"">
                <div class=""write_name"">
                    <div class=""name_box"">Write</div>
                </div>
                <div class=""description"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f922ffd3e149a992d7ff06e4c327caf0f2a90da17784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 114 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f922ffd3e149a992d7ff06e4c327caf0f2a90da19673", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 120 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <button id=""add_file"">
                        Attach files by dragging & dropping, selecting or pasting them.
                    </button>
                    <input type=""file"" id=""attach_file"" />
                </div>
                <button type=""submit"" id=""submit_comment"">Comment</button>
            </div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1f922ffd3e149a992d7ff06e4c327caf0f2a90da21611", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 128 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IssueId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
                                WriteLiteral(ViewBag.Issue.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n      </div>\r\n    \r\n  \r\n\r\n    <div class=\"all_label_names details\">\r\n      \r\n      <div class=\"assignees\">\r\n        <div class=\"asn_title\">Assigned to:</div>\r\n");
#nullable restore
#line 139 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
         foreach(var item in @ViewBag.Issue.AllAssigned){
       

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 141 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
         Write(item.Assigned.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 142 "C:\Users\Admin\Desktop\CodingDojo\IssueTrackingSystem\Views\Home\IssueDetails.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n    </div>\r\n</div>\r\n</div>\r\n\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f922ffd3e149a992d7ff06e4c327caf0f2a90da26444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f922ffd3e149a992d7ff06e4c327caf0f2a90da27484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IssueTrackingSystem.Models.IssueBase.Comments> Html { get; private set; }
    }
}
#pragma warning restore 1591
