using DigitalPayments.Domain.Entities;
using DigitalPayments.Infraestructure.Abstractions;
using System;

namespace DigitalPayments.Infraestructure.Repositories
{
    public class CardRepository : ICardRepository
    {
        public Card CreateCard(Card card)
        {
            //TODO
            try
            {
                return new Card { };
            }
            catch (Exception)
            {
                return null;                
            }
        }
    }
}
