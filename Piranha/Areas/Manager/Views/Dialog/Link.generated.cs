﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Dialog
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Dialog/Link.cshtml")]
    public partial class Link : System.Web.Mvc.WebViewPage<Piranha.Areas.Manager.Models.LinkDialogModel>
    {
        public Link()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Dialog\Link.cshtml"
  
    Layout = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"box-tabs\"");

WriteLiteral(">\r\n        <li");

WriteLiteral(" class=\"selected\"");

WriteLiteral("><a");

WriteLiteral(" class=\"btn-link-page\"");

WriteLiteral(" href=\"#link-page\"");

WriteLiteral(">Pages</a></li>\r\n        <li><a");

WriteLiteral(" class=\"btn-link-media\"");

WriteLiteral(" href=\"#link-media\"");

WriteLiteral(">Media</a></li>\r\n    </ul>\r\n    <a");

WriteLiteral(" class=\"close-btn right\"");

WriteLiteral(" data-id=\"boxLink\"");

WriteLiteral("></a>\r\n    <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n</div>\r\n<div");

WriteLiteral(" id=\"link-page\"");

WriteLiteral(" class=\"inner link-page\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"sitemap\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..\Areas\Manager\Views\Dialog\Link.cshtml"
   Write(Html.Partial("Partial/DialogSiteTree", Model.Pages));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </ul>\r\n    <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"loader\"");

WriteLiteral("></div>\r\n</div>\r\n<div");

WriteLiteral(" id=\"link-media\"");

WriteLiteral(" class=\"inner link-media hidden\"");

WriteLiteral(">\r\n    Yo my man\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
