#pragma checksum "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d65cb6f66b9c313451ee18a00c953ece5367f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllClosing), @"mvc.1.0.view", @"/Views/Home/AllClosing.cshtml")]
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
#line 1 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d65cb6f66b9c313451ee18a00c953ece5367f2", @"/Views/Home/AllClosing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f76db85423d1966422131999df760b0ec79fa9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllClosing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Boat>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
  
    var cultureFr = new CultureInfo("fr-FR");
    ViewData["Title"] = "Toutes les fermetures";
    int id = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 8 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>


<h3>Fermetures à venir :</h3>
<table class=""table"">
    <thead>
        <tr>
            <th>Bateau concerné :</th>
            <th>Prochaine fermeture :</th>
            <th>Durée de la fermeture :</th>
            <th>Lien de détails de fermeture :</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
             foreach (var item in Model)
            {
                if (item._closingDate >= DateTime.Today) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                       Write(item._boatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                       Write(item._closingDate.ToString("dddd d MMMM, hh:mm", cultureFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                       Write(item._blockDuree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" heures</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d65cb6f66b9c313451ee18a00c953ece5367f26366", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                                                                                        WriteLiteral(id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                }
                id++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<h3>Fermetures passées :</h3>
<table class=""table"">
    <thead>
        <tr>
            <th>Bateau concerné :</th>
            <th>Prochaine fermeture :</th>
            <th>Durée de la fermeture :</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
             foreach (var item in Model)
            {
                if (item._closingDate < DateTime.Today) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                       Write(item._boatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                       Write(item._closingDate.ToString("dddd d MMMM, hh:mm", cultureFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                       Write(item._blockDuree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" heures</td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\AllClosing.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Boat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
