using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Think.Application.SystemManage;
using Think.Code;
using Think.Domain.Entity.SystemManage;

namespace Think.Web.Controllers
{
    [HandlerLogin]
    public class EmailController : Controller
    {
       
        // GET: Email
        public ActionResult MailBox()
        {
            return View();
        }
        public ActionResult Mail_Detail()
        {
            return View();
        }
        public ActionResult Mail_Compose()
        {
            return View();
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult EmailBoxList(int page , int index )
        {
            var count = new EmailApp().GetEmailCount(-1);
            //返回当前第几页
            var data = new
            {
                _index_count = count/page +count%page, //总条数/页规格 = 总页数
                _index = index, //当前页数
                email = new EmailApp().GetEmailList(page, index),
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 已读
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult MarkedRead(string keys)
        {
            var i = new EmailApp().MarkedRead(keys);
            if(i>0)
                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "变更成功" }.ToJson());
            else
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = "变更失败" }.ToJson());
        }

        /// <summary>
        /// 邮件详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult Email_Deatil(string id)
        {
            var emailApp = new EmailApp();
            if (!string.IsNullOrWhiteSpace(id))
            {
                var entity =  emailApp.Email_Detail(id);
                var email_path = emailApp.Email_Path(id);
                var accountinfo = emailApp.AccountInfo(entity.PF_Out_UserID);
                var data = new
                {
                   // email_key = id,
                    Title = entity.PF_Title,
                    Msg = entity.PF_MSG,
                    Time = entity.PF_CreateTime,
                    Send = accountinfo == null ? null:accountinfo.PF_UName,
                    Path_Zip = email_path ==null ? null: email_path.PF_Src , //下载全部 zip地址
                    Path_Png = email_path == null ? null : email_path.PF_FileName, //文件路径  可能多个
                    Doc_Count = email_path == null ? null : email_path.PF_FileName.Split(',').Count().ToString() //文件数量
                };
                return Content(data.ToJson());
            }
            else
                return Content(null);
        }

        /// <summary>
        /// 下载附件 keyvalue email_id  type 下载全部zip 还是单个
        /// </summary>
        /// <param name="keyvalue"></param>
        [HttpPost]
        [HandlerAuthorize]
        public void DownLoadEmailFiles(string keyvalue,string type)
        {
            var data = new EmailApp().Email_Path(keyvalue);
            string filename = "";
            string filepath = "";
            if (type == ".zip")
            {
                //文件名
                filename = Server.UrlDecode(data.PF_Src.Substring(data.PF_Src.LastIndexOf("/")+1));
                //路径
                filepath = Server.MapPath(data.PF_Src);
                
            }
            else
            {
                filename = Server.UrlDecode(type);
                filepath = Server.MapPath(data.PF_Src.Replace(data.PF_Src.Substring(data.PF_Src.LastIndexOf("/")), "")+"/" + filename);
            }
            filepath = filepath.Replace("\\Email\\DownLoadEmailFiles", "");

           // return File(new System.IO.FileStream(filepath, System.IO.FileMode.Open), "application/octet-stream", filename);

            if (FileDownHelper.FileExists(filepath))
            {
                FileDownHelper.DownLoadold(filepath, filename);
            }
        }

        /// <summary>
        /// 根据邮件ID获取发件人
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult GetSendUser(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var email = new EmailApp().Email_Detail(id);
                var user = new EmailApp().AccountInfo(email.PF_Out_UserID).PF_UName;
                return Content(user);
            }
            else
                return null;
        }

        /// <summary>
        /// 写邮件
        /// </summary>
        /// <param name="msg">内容</param>
        /// <param name="ResultUser">收件人</param>
        /// <param name="Title">标题</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult SendEmail()
        {
            try
            {
                string ResultUser = Request.Form["ResultUser"];
                ResultUser = ResultUser.Replace("@Think.com", "");     //收件人
                string Title = Request.Form["Title"];                  //标题
                var msg = DecodeBase64("utf-8", Request.Form["msg"]);  //前端针对BASE 编码
                                                                       //获取HTML 数组
                var htmlarry = WebHelper.GetHTML_Img(msg);
                //获取HTML数组里的base码
                var base_ = WebHelper.GetImgUrl(htmlarry);
                //根据base下载文件
                bool b = WebHelper.SaveImgByBase(base_, out List<string> ImgName);
                if (b) //保存文件系统成功
                {
                    //把img 的src  依次替换
                    //新的_html 内容
                    var _html = msg;
                    if (base_ != null)
                    {
                        for (int i = 0; i < base_.Length; i++)
                        {
                            _html = _html.Replace(base_[i], "/UploadImg/" + ImgName[i]);
                        }
                    }
                    //插入数据库
                    var sys_Email = new Sys_Email()
                    {
                        PF_CreateTime = DateTime.Now,
                        PF_In_UserID = new UserApp().GetUserKeyByName(ResultUser).ToString(),
                        PF_Out_UserID = OperatorProvider.Provider.GetCurrent().UserId.ToString(),
                        PF_MSG = _html,
                        PF_IsRead = 0,
                        PF_Title = Title,
                    };
                    new EmailApp().SendMail(sys_Email);
                }
                return Content("发送成功");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }



        ///解码
        public static string DecodeBase64(string code_type, string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = System.Text.Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

    }
}