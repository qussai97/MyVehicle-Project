using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
 public interface IContactRepoisitory
    {
        public bool InsertContact(Contact contact);
        public bool UpdateContact(Contact contact);
        public bool DeleteContact(int id);
        public List<Contact> GetAllContact();
    }
}
