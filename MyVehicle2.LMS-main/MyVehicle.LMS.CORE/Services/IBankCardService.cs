using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IBankCardService
    {
        public List<BankCard> GetAllBankCard();

        public bool InsertBankCard(BankCard bankCard);
        public bool UpdateBankCard(BankCard bankCard);
        public bool DeleteBankCard(int id);
        public BankCard GetBankCardById(BankCard bankCard);
    }
}
