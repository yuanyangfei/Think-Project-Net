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

        public List<Sys_Custorm> GetCustorms()
        {
            return contacts.GetCustorms();
        }
    }
}
