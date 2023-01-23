using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class CardService : ICardService
    {
        private readonly ICardsRepoisitory cardsRepoisitory;
        public CardService(ICardsRepoisitory cardsRepoisitory)
        {
            this.cardsRepoisitory = cardsRepoisitory;
        }
        public bool DeleteCards(int id)
        {
            return cardsRepoisitory.DeleteCards(id);
        }

        public List<Cards> GetAllCards()
        {
            return cardsRepoisitory.GetAllCards();
        }

        public List<Cards> GetCardById(int UserId)
        {
            return cardsRepoisitory.GetCardById(UserId);
        }

        public bool InsertCards(Cards cards)
        {
            return cardsRepoisitory.InsertCards(cards);

        }

        public bool UpdateCards(Cards cards)
        {
            return cardsRepoisitory.UpdateCards(cards);
        }
    }
}
