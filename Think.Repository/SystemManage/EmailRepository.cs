
using System.Collections.Generic;
using System.Linq;
using Think.Data;
using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;

namespace Think.Repository.SystemManage
{
    public class EmailRepository:IEmailRepository
    {
        SqlSugar.SqlSugarClient db = DemoBase.GetInstance();

        public List<Sys_Email> GetUserEmails(int in_users)
        {
            return db.Queryable<Sys_Email>().Where(x => x.PF_In_UserID == in_users.ToString()).OrderBy("PF_CreateTime desc").ToList();
        }

        public int GetUserEmailCount(int in_Users)
        {
            return GetUserEmails(in_Users).Count;
        }

        public List<Sys_Email> GetUserEmailGridList(int in_users, int? pageSize, int? index)
        {
            var expression = GetUserEmails(in_users);
            var list = expression.OrderByDescending(t => t.PF_CreateTime).Skip((index.Value - 1) * pageSize.Value).Take(pageSize.Value).ToList();
            return list;
        }

        public int GetUserEmails(int in_users,int isread)
        {
            return db.Queryable<Sys_Email>().WhereIF(isread!=-1,x=>x.PF_IsRead == isread).Where(x => x.PF_In_UserID == in_users.ToString()).Count();
        }

        /// <summary>
        /// 根据条件修改阅读状态
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public int MarkedRead(string keys)
        {
            var i = db.Updateable<Sys_Email>()
.UpdateColumns(it => new Sys_Email() { PF_IsRead = 1 })
.Where(it => keys.Contains(it.PF_ID.ToString())).ExecuteCommand();
            return i;
        }

        /// <summary>
        /// 邮件详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sys_Email Email_Detail(string id)
        {
            return db.Queryable<Sys_Email>().First(x => x.PF_ID.ToString() == id);  
        }

        /// <summary>
        /// 详情中邮件的文件路径
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sys_Email_Path Email_Path(string id)
        {
            return db.Queryable<Sys_Email_Path>().First(x => x.PF_EmailID.ToString() == id);
        }

        /// <summary>
        /// 查询人名
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sys_AccountInfo AccountInfo(string id)
        {
            return db.Queryable<Sys_AccountInfo>().First(x => x.PF_ID.ToString() == id);
        }

        public bool SendMail(Sys_Email sys_Email)
        {
            return db.Insertable<Sys_Email>(sys_Email).ExecuteReturnIdentity() > 0;
        }

    }
}
