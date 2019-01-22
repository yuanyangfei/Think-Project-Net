using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Think.Application.SystemManage;
using Think.Code;
using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;
using Think.Repository.SystemManage;
using Think.Web.App_Start;

namespace Think.Web.Controllers
{
    [HandlerLogin]
    public class HomeController : Controller
    {
        private DataConfig data = new DataConfig();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetClientsDataJson()
        {
            var data = new
            {
                emailcount = new EmailApp().GetEmailCount(-1), //所有邮件数量
                email = new EmailApp().GetEmailCount(0), //未读数量
                authorizeMenu = this.GetMenuList(),
            };
            return Content(data.ToJson());
        }

        private object GetMenuList()
        {
            return ToMenuJson(data.modelRepository.GetNavModelEntity(),0); //本该权限
        }
        /// <summary>
        /// 遍历节点： 找到父节点然后代入查询ChildNodes子节点
        /// </summary>
        /// <param name="data"></param>
        /// <param name="parentid"></param>
        /// <returns></returns>
        private string ToMenuJson(List<Sys_Model> datas,int parentid)
        {
            StringBuilder sbJson = new StringBuilder();
            sbJson.Append("[");
            List<Sys_Model> entitys = data.modelRepository.GetNavModelEntity(parentid);// new ModelRepository().GetNavModelEntity(parentid);
            if (entitys.Count > 0)
            {
                foreach (var item in entitys)
                {
                    string strJson = item.ToJson();
                    strJson = strJson.Insert(strJson.Length - 1, ",\"ChildNodes\":" + ToMenuJson(datas, item.PF_ID) + "");
                    sbJson.Append(strJson + ",");
                }
                sbJson = sbJson.Remove(sbJson.Length - 1, 1);
            }
            sbJson.Append("]");
            return sbJson.ToString();
        }
    }
}