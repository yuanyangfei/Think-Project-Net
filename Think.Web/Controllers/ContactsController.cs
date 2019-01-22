using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Think.Application.SystemManage;
using Think.Code;
using Think.Domain.Entity.SystemManage;

namespace Think.Web.Controllers
{
    [HandlerLogin]
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            return View();
        }

        //获取联系人列表
        public ActionResult GetPeople()
        {
            var data = new
            {
                people = new ContactsApp().GetCustorms()
            };
            return Content(data.ToJson());
        }
    }
}