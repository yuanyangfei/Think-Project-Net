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
        public List<Sys_Custorm> GetCustorms(string name)
        {
            return db.Queryable<Sys_Custorm>().WhereIF(!string.IsNullOrWhiteSpace(name),x=>x.PF_NAME.Contains(name)||x.PF_COMPANY.Contains(name)).ToList();
        }

        public IEnumerable<Sys_Custorm> GetCustorms(string name, int pageIndex, int pageSize)
        {
            return db.Queryable<Sys_Custorm>().WhereIF(!string.IsNullOrWhiteSpace(name), x => x.PF_NAME.Contains(name) || x.PF_COMPANY.Contains(name)).OrderBy(x => x.PF_ID).ToList().AsQueryable();
        }

    }

}
