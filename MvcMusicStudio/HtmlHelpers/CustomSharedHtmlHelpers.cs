using System;
using System.Web.Mvc;

namespace MvcMusicStudio.HtmlHelpers
{
    public class CustomSharedHtmlHelpers
    {
        /* long name for now, so I can eaisly undersatnd the code 
         * but I think something like TableActionLink would be fine
         *
         */
        public static MvcHtmlString TableActionLink(HtmlHelper htmlHelper, string linkText, string actionName, object routeValues, object htmlAttributes)
        {
            return System.Web.Mvc.Html.LinkExtensions.ActionLink(htmlHelper, linkText, actionName, routeValues, new { @class = "btn btn-primary" });
        }
    }
}