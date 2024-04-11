using DigitalPayments.Domain.Entities;

namespace DigitalPayments.Application.Absctractions
{
    public interface ICardService
    {
        public Card ProcessCard(Card card);
        public Card CreateCard(Card card, string token);
    }
}
