using System;
using System.Collections.Generic;
using System.Linq;
using Think.Data;
using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;

namespace Think.Repository.SystemManage
{
    public class ContactsRepository: IContactsRepository
    {
        SqlSugar.SqlSugarClient db = DemoBase.GetInstance();

        /// <summary>
        /// 加载所有联系人
        /// </summary>
        public List<Sys_Custorm> GetCustorms()
        {
            return db.Queryable<Sys_Custorm>().ToList();
        }


    }

}
