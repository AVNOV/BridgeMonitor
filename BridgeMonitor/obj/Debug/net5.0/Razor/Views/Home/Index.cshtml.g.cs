#pragma checksum "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e10c3eaf6c4a58edcc8e63bf2a193ac3c6bcddd1"
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
#line 2 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10c3eaf6c4a58edcc8e63bf2a193ac3c6bcddd1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f76db85423d1966422131999df760b0ec79fa9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
  
    var cultureFr = new CultureInfo("fr-FR");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Prochaine Fermeture</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Prochaine fermeture :</th>
            <th>Prochaine réouverture :</th>
            <th>Bateau concerné :</th>
            <th>Durée de la fermeture :</th>
            <th>Rique de bouchon :</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 21 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
           Write(Model._closingDate.ToString("dddd d MMMM, hh:mm", cultureFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
           Write(Model._reopeningDate.ToString("dddd d MMMM, hh:mm", cultureFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
           Write(Model._boatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
           Write(Model._blockDuree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" heures</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\35Master\Desktop\POO ARCHI\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
           Write(Model._jamRisks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boat> Html { get; private set; }
    }
}
#pragma warning restore 1591
