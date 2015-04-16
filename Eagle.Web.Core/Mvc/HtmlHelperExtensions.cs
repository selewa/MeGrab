using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Eagle.Web.Core.Mvc
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString RedirectLink(this HtmlHelper htmlHelper, 
                                                 string linkText, 
                                                 string url, 
                                                 IDictionary<string, object> htmlAttributes)
        {
            return RedirectLink(htmlHelper, linkText, url, null, htmlAttributes);
        }

        public static MvcHtmlString RedirectLink(this HtmlHelper htmlHelper,
                                                 string linkText,
                                                 string baseUrl,
                                                 IDictionary<string, string> queryStrings)
        {
            return RedirectLink(htmlHelper, linkText, baseUrl, queryStrings, null);
        }
    
        public static MvcHtmlString RedirectLink(this HtmlHelper htmlHelper, 
                                                 string linkText, 
                                                 string baseUrl, 
                                                 IDictionary<string, string> queryStrings,
                                                 IDictionary<string, object> htmlAttributes)
        {
            StringBuilder queryStringBuilder = new StringBuilder();
            if (queryStrings != null)
            {
                foreach(KeyValuePair<string, string> queryStringPair in queryStrings)
                {
                    queryStringBuilder.AppendFormat("{0}={1}&", queryStringPair.Key, queryStringPair.Value);
                }
            }

            string wholeUrl = baseUrl.TrimEnd('?') + "?" + queryStringBuilder.ToString().TrimEnd('&');

            var builder = new TagBuilder("a");
            builder.MergeAttribute("href", wholeUrl);
            builder.MergeAttribute("target", "_blank");
            builder.MergeAttributes<string, object>(htmlAttributes, true);
            builder.SetInnerText(linkText);
            builder.ToString(TagRenderMode.SelfClosing);
            return MvcHtmlString.Create(builder.ToString());
        }
    }
}
