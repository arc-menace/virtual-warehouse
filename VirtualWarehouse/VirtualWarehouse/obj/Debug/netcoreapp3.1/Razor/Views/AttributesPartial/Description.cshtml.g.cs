#pragma checksum "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\AttributesPartial\Description.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e09103834abfd277324b2d510c9a9201f24e951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AttributesPartial_Description), @"mvc.1.0.view", @"/Views/AttributesPartial/Description.cshtml")]
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
#line 2 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\AttributesPartial\Description.cshtml"
using VirtualWarehouse.Data.Models.Attributes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e09103834abfd277324b2d510c9a9201f24e951", @"/Views/AttributesPartial/Description.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a206d2db43c9806f7b24789dfa4a7b6dddb4e3e3", @"/Views/_ViewImports.cshtml")]
    public class Views_AttributesPartial_Description : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Description>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 7 "C:\Development\virtual-warehouse\VirtualWarehouse\VirtualWarehouse\Views\AttributesPartial\Description.cshtml"
Write(Model.DescriptionContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Description> Html { get; private set; }
    }
}
#pragma warning restore 1591
