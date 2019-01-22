using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Think.Domain.Entity.SystemManage;
using Think.Application.SystemManage;
using Think.Code;
using Think.Application;
namespace Think.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult CheckLogin(string username, string password)
        {
            Sys_AccountInfo Sys_AccountInfo_Entity_ = new Sys_AccountInfo();
            Sys_AccountInfo_Entity_.PF_UName = username;
            Sys_AccountInfo_Entity_.PF_UPwd = password;
            Sys_Log_Entity sys_Log_Entity = new Sys_Log_Entity(); //记录日志
            sys_Log_Entity.PF_ModelName = "访客登陆";
            sys_Log_Entity.PF_Type = DbLogType.Login.ToString();  //枚举操作类型
            try {
                var userEntity = new UserApp().CheckLogin(Sys_AccountInfo_Entity_);
                if (userEntity != null)
                {
                    OperatorModel operatorModel = new OperatorModel();
                    operatorModel.UserId = userEntity.PF_ID;
                    operatorModel.UserName = userEntity.PF_UName;
                    operatorModel.LoginIPAddress = Net.Ip;
                    operatorModel.LoginIPAddressName = Net.GetLocation(operatorModel.LoginIPAddress);
                    operatorModel.LoginTime = DateTime.Now;
                    operatorModel.LoginToken = DESEncrypt.Encrypt(Guid.NewGuid().ToString());
                    OperatorProvider.Provider.AddCurrent(operatorModel);
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "登录成功。" }.ToJson());
                }
                else
                    return Content(new AjaxResult { state = ResultType.error.ToString(), message = "登录失败。" }.ToJson());
            } catch (Exception ex) {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = "登录失败。" }.ToJson());
            }
        }
    }
}