
using System.Collections.Generic;
using Think.Domain.Entity.SystemManage;

namespace Think.Domain.IRepository.SystemManage
{
    public interface IContactsRepository
    {
        List<Sys_Custorm> GetCustorms();
    }
}
