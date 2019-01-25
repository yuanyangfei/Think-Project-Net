using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;
using Think.Repository.SystemManage;

namespace Think.Application.SystemManage
{
    public class ContactsApp
    {
        private IContactsRepository contacts = new ContactsRepository();

        public List<Sys_Custorm> GetCustorms(string str)
        {
            return contacts.GetCustorms(str);
        }
        public IEnumerable<Sys_Custorm> GetCustorms(string name, int pageIndex, int pageSize)
        {
            return contacts.GetCustorms(name, pageIndex, pageSize);
        }
    }
}
