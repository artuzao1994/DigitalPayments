using DigitalPayments.Domain.Entities;

namespace DigitalPayments.Infraestructure.Abstractions
{
    public interface ICardRepository
    {
        public Card CreateCard(Card card);
    }
}
