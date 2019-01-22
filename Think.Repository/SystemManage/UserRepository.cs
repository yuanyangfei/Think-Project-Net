/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using Think.Code;
using Think.Data;
using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;

namespace Think.Repository.SystemManage
{
   
    public class UserRepository :  IUserRepository
    {
        SqlSugar.SqlSugarClient db = DemoBase.GetInstance();
        public Sys_AccountInfo GetUserInfoEntity(Sys_AccountInfo item)
        {
            return db.Queryable<Sys_AccountInfo>().First(x => x.PF_UName == item.PF_UName && x.PF_UPwd == item.PF_UPwd);
        }

        public int GetUserKeyByName(string Name)
        {
            return db.Queryable<Sys_AccountInfo>().First(x => x.PF_UName == Name).PF_ID;
        }
    }
}
