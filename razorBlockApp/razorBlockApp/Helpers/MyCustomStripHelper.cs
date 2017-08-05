using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace razorBlockApp.Helpers
{
    public static class MyCustomStripHelper
    {
        public static MvcHtmlString myHtmlStrip(this HtmlHelper html, string inputHtml)
        {
            return new MvcHtmlString(System.Text.RegularExpressions.Regex.Replace(inputHtml,"<.*?>",string.Empty));
        }
    }
}