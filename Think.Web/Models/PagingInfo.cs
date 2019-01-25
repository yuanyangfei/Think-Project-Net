using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Think.Web.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        //当前索引
        public int PageIndex { get; set; }
        //分页大小
        public int PageSize { get; set; }
        //页数
        public int PageCount
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / PageSize);
            }
        }
    }
}