using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
  public  interface ICardService
    {
        public bool InsertCards(Cards cards);
        public bool UpdateCards(Cards cards);
        public bool DeleteCards(int id);
        public List<Cards> GetAllCards();
        public List<Cards> GetCardById(int UserId);
    }
}
