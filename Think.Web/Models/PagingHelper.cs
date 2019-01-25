using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Think.Web.Models
{
    public static class PagingHelper
    {
        //HtmlHelper扩展方法，用于分页
        public static MvcHtmlString Pagination(this HtmlHelper html, PagingInfo pageInfo, Func<PagingInfo, string> pageLinks)
        {
            var htmlString = pageLinks(pageInfo);

            return MvcHtmlString.Create(htmlString);
        }
    }
}