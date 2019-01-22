using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;
using Think.Repository.SystemManage;
using System;
using Think.Code;
using System.Linq;
using System.Collections.Generic;

namespace Think.Application.SystemManage
{
   public class EmailApp
    {
        private IEmailRepository emailRepository = new EmailRepository();
        
        public int GetEmailCount(int isread)
        {
            var key = OperatorProvider.Provider.GetCurrent().UserId;
            return emailRepository.GetUserEmails(key,isread);
        }
        /// <summary>
        /// 邮件列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<Sys_Email> GetEmailList(int page,int index)
        {
            var key = OperatorProvider.Provider.GetCurrent().UserId;
            return emailRepository.GetUserEmailGridList(key,page,index);
        }
        /// <summary>
        /// 更新阅读状态
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public int MarkedRead(string keys)
        {
            return emailRepository.MarkedRead(keys);
        }

        /// <summary>
        /// 邮件详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sys_Email Email_Detail(string id)
        {
            return emailRepository.Email_Detail(id);
        }

        public Sys_Email_Path Email_Path(string id)
        {
            return emailRepository.Email_Path(id);
        }

        public Sys_AccountInfo AccountInfo(string id)
        {
            return emailRepository.AccountInfo(id);
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <returns></returns>
        public bool SendMail(Sys_Email sys_Email)
        {
            return emailRepository.SendMail(sys_Email);
        }
    }
}
