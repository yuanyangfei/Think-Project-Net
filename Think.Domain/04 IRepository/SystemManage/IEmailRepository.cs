using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Think.Domain.Entity.SystemManage;

namespace Think.Domain.IRepository.SystemManage
{
    public interface IEmailRepository
    {
        /// <summary>
        /// 根据收件人获取邮件
        /// </summary>
        /// <param name="in_users"></param>
        /// <returns></returns>
        List<Sys_Email> GetUserEmails(int in_users);

        /// <summary>
        /// 未读邮件数量
        /// </summary>
        /// <param name="in_users"></param>
        /// <param name="isread"></param>
        /// <returns></returns>
        int GetUserEmails(int in_users, int isread);

        /// <summary>
        /// Email 列表分页
        /// </summary>
        /// <param name="in_users"></param>
        /// <param name="pageSize"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        List<Sys_Email> GetUserEmailGridList(int in_users, int? pageSize, int? index);

        /// <summary>
        /// 更新阅读状态
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        int MarkedRead(string keys);

        /// <summary>
        /// 邮件详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Sys_Email Email_Detail(string id);

        /// <summary>
        /// 下载全部 文件集合
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Sys_Email_Path Email_Path(string id);

        Sys_AccountInfo AccountInfo(string id);

        /// <summary>
        /// 写邮件
        /// </summary>
        /// <param name="sys_Email"></param>
        /// <returns></returns>
        bool SendMail(Sys_Email sys_Email);
    }
}
