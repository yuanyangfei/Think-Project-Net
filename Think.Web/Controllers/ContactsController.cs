using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Think.Application.SystemManage;
using Think.Code;
using Think.Domain.Entity.SystemManage;
using Think.Web.Models;
using Think.Web.Models.Contacts;

namespace Think.Web.Controllers
{
    [HandlerLogin]
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index(string searchKey, int Index=1,int pageSize=6)
        {
            //当前分页数据集合
            var model = new ContactsApp().GetCustorms(searchKey, Index, pageSize);
            var newmodel = model.Skip((Index - 1) * pageSize).Take(pageSize);
            //当前ViewModel传递试图
            BasePageModel page = new BasePageModel() { SearchKeyWord = searchKey
                ,
                CurrentIndex = Int32.Parse(Index.ToString()), TotalCount = model.Count() };
            ViewData["pagemodel"] = page;
            return View(new ContactsViewModel {
                SearchKey = searchKey,
                Posts = newmodel,
                PageModel = page,
                PagingInfo =new Models.PagingInfo {
                    TotalItems  = model.Count(),
                    PageIndex = Index,
                    PageSize = pageSize
                }
            });
        }

        //获取联系人列表
        public ActionResult GetPeople(string name)
        {
            var data = new
            {
                people = new ContactsApp().GetCustorms(name)
            };
            return Content(data.ToJson());
        }
    }
}