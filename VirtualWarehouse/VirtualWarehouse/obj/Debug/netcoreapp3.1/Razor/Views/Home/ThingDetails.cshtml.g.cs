#pragma checksum "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1bf1508150d82bf7467c8a04b90584d66ba794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ThingDetails), @"mvc.1.0.view", @"/Views/Home/ThingDetails.cshtml")]
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
#line 1 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\_ViewImports.cshtml"
using VirtualWarehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\_ViewImports.cshtml"
using VirtualWarehouse.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
using VirtualWarehouse.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a1bf1508150d82bf7467c8a04b90584d66ba794", @"/Views/Home/ThingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a206d2db43c9806f7b24789dfa4a7b6dddb4e3e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ThingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThingDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateThingAttribute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                                       
    ViewData["Title"] = Model.Thing.ThingName + " - Details";
    string selectedAttributeType = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a1bf1508150d82bf7467c8a04b90584d66ba7945889", async() => {
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
            WriteLiteral(@"

<div class=""container-fluid container-fluid-no-padding"">
    <div class=""row"">
        <div class=""col menu-bar"">
            <!--This is the side menu which displays options for thing-->
            Menu bar
        </div>
        <div class=""col main-content"">
            <!--This is the main portion of the page, where the attributes will be displayed-->
            Main Content
");
#nullable restore
#line 19 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
             if (Model.Thing.Attributes.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                 foreach (var attri in Model.Thing.Attributes)
                {
                    string partialName = "~/Views/AttributesPartial/" + attri.AttributeType + ".cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-auto mb-3\">\r\n                        <div class=\"card\" style=\"width: 20rem;\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 27 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                                                  Write(attri.AttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a1bf1508150d82bf7467c8a04b90584d66ba7948633", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                                  WriteLiteral(partialName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => attri);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 33 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
             if (Model.AttributeTypes.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                 foreach (var att in Model.AttributeTypes)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
               Write(att);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                        
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <button type=""button"" class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#createThingAttributeModal"">+</button>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""createThingAttributeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""createThingAttributeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createThingAttributeModalLabel"">Create New Attribute</h5>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a1bf1508150d82bf7467c8a04b90584d66ba79413173", async() => {
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-group\">\r\n                        <select id=\"typeSelector\" class=\"form-select\" aria-label=\"Default select example\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a1bf1508150d82bf7467c8a04b90584d66ba79413672", async() => {
                    WriteLiteral("Select Attribute Type");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                             for(int i = 0; i < Model.AttributeTypes.Count(); i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a1bf1508150d82bf7467c8a04b90584d66ba79415386", async() => {
#nullable restore
#line 62 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                                                         Write(Model.AttributeTypes[i]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                                   WriteLiteral(i.ToString());

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                        <label for=""newThingAttributeName"">Name</label>
                        <input type=""text"" class=""form-control"" id=""newThingAttributeName"" name=""name"" placeholder=""Enter Name"" required>
                        <input type=""hidden"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 3052, "\"", 3080, 1);
#nullable restore
#line 67 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\Home\ThingDetails.cshtml"
WriteAttributeValue("", 3060, Model.Thing.ThingId, 3060, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <input type=""hidden"" id=""hiddenType"" name=""type""/>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary"">Create</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#typeSelector\").change(function () {\r\n            $(\"#hiddenType\").val($(\"#typeSelector option:selected\").text());\r\n        })\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThingDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
