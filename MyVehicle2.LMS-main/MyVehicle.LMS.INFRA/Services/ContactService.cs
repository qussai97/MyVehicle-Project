using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepoisitory contactRepoisitory;
        public ContactService(IContactRepoisitory contactRepoisitory)
        {
            this.contactRepoisitory = contactRepoisitory;
        }
        public bool DeleteContact(int id)
        {
            return contactRepoisitory.DeleteContact(id);
        }

        public List<Contact> GetAllContact()
        {
            return contactRepoisitory.GetAllContact();        }

        public bool InsertContact(Contact contact)
        {
            return contactRepoisitory.InsertContact(contact);
        }

        public bool UpdateContact(Contact contact)
        {
            return contactRepoisitory.UpdateContact(contact);
        }
    }
}
