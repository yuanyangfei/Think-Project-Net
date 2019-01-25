
using System.Collections.Generic;
using Think.Domain.Entity.SystemManage;

namespace Think.Domain.IRepository.SystemManage
{
    public interface IContactsRepository
    {
        List<Sys_Custorm> GetCustorms(string str);
        IEnumerable<Sys_Custorm> GetCustorms(string name,int pageIndex,int pageSize);
    }
}
