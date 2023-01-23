using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;

using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class BankCardService : IBankCardService
    {
        private readonly IBankCardRepoisitory bankCardRepoisitory ;
        public BankCardService(IBankCardRepoisitory bankCardRepoisitory)
        {
            this.bankCardRepoisitory = bankCardRepoisitory;
        }
        public bool DeleteBankCard(int id)
        {
          return bankCardRepoisitory.DeleteBankCard(id);
        }

        public List<BankCard> GetAllBankCard()
        {
            return bankCardRepoisitory.GetAllBankCard();
        }

        public BankCard GetBankCardById(BankCard bankCard)
        {
            return bankCardRepoisitory.GetBankCardById(bankCard);
        }

        public bool InsertBankCard(BankCard bankCard)
        {
            return bankCardRepoisitory.InsertBankCard(bankCard);
        }

        public bool UpdateBankCard(BankCard bankCard)
        {
            return bankCardRepoisitory.UpdateBankCard(bankCard);
        }
    }
}
