using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Think.Domain.Entity.SystemManage;

namespace Think.Web.Models.Contacts
{
    public class ContactsViewModel
    {
        //联系人集合
        public IEnumerable<Sys_Custorm> Posts { get; set; }
        //分页参数
        public PagingInfo PagingInfo { get; set; }
        //条件参数
        public string SearchKey { get; set; }
        public BasePageModel PageModel { get; set; }
    }
}