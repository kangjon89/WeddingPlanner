#pragma checksum "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6420874d70ccebbee6b3be2986d4f95b634c54d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6420874d70ccebbee6b3be2986d4f95b634c54d", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 175, true);
            WriteLiteral("<marquee direction=\"scroll\">\r\n    <img src=\"https://media1.tenor.com/images/abb9bb0bb79865bfc4ac963d4c30eb7a/tenor.gif?itemid=11191352\" height=\"75\" width=\"75\">\r\n</marquee>\r\n\r\n");
            EndContext();
            BeginContext(197, 366, true);
            WriteLiteral(@"
<h1>Welcome to the Wedding Planner <a href=""/logout"" class=""btn btn-danger"">Log Out</a></h1>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Wedding</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">Guests</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
         foreach (var wedding in Model)
        {

#line default
#line hidden
            BeginContext(615, 40, true);
            WriteLiteral("            <tr>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 655, "\"", 681, 2);
            WriteAttributeValue("", 662, "/", 662, 1, true);
#line 21 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 663, wedding.WeddingId, 663, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(684, 17, false);
#line 21 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                             Write(wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(701, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(705, 17, false);
#line 21 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                  Write(wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(722, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(754, 12, false);
#line 22 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
               Write(wedding.Date);

#line default
#line hidden
            EndContext();
            BeginContext(766, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(794, 28, false);
#line 23 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
               Write(wedding.Assossications.Count);

#line default
#line hidden
            EndContext();
            BeginContext(822, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 24 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
                 if (wedding.UserId == ViewBag.UserId)
                {

#line default
#line hidden
            BeginContext(904, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 930, "\"", 963, 2);
            WriteAttributeValue("", 937, "/delete/", 937, 8, true);
#line 26 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 945, wedding.WeddingId, 945, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(964, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 27 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
                }
                else {
                    

#line default
#line hidden
#line 29 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
                     if(@wedding.Assossications.All(j=>j.UserId != @ViewBag.weddingId))
                    {

#line default
#line hidden
            BeginContext(1137, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1163, "\"", 1194, 2);
            WriteAttributeValue("", 1170, "/rsvp/", 1170, 6, true);
#line 31 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1176, wedding.WeddingId, 1176, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1195, 66, true);
            WriteLiteral(" class=\"btn btn-primary\">JOIN</a></td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1261, "\"", 1294, 2);
            WriteAttributeValue("", 1268, "/unrsvp/", 1268, 8, true);
#line 32 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1276, wedding.WeddingId, 1276, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1295, 40, true);
            WriteLiteral(" class=\"btn btn-danger\">LEAVE</a></td>\r\n");
            EndContext();
#line 33 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
                    }

#line default
#line hidden
#line 33 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1377, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Jonathan Kang\Documents\Coding Dojo\C #\WeddingPlanner\Views\Home\Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(1407, 102, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"New\"><button class=\"btn btn-primary\">New Wedding</button></a>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
