using DigitalPayments.Application.Absctractions;
using DigitalPayments.Domain.Entities;
using DigitalPayments.Infraestructure.Abstractions;
using DigitalPayments.Infraestructure.Repositories;
using DigitalPayments.Infraestructure.Services;

namespace DigitalPayments.Application.Services
{
    public class CardService : ICardService
    {
        private readonly IProviderService _providerService;
        private readonly ICardRepository _cardRepository;
        public CardService(IProviderService providerService, ICardRepository cardRepository)
        {
            _providerService = providerService;
            _cardRepository = cardRepository;
        }

        public Card ProcessCard(Card card)
        {
            string token = _providerService.ProcessCard(card);

            if (token == null) {
                return null;
            };           

            return CreateCard(card, token);
        }

        public Card CreateCard(Card card, string token)
        {
            Card cardToSave = new Card()
            {
                Id = 1,
                CVV = card.CVV,
                Number = card.Number,
                Token = token,
            };
            return _cardRepository.CreateCard(cardToSave);       
        }  
    }
}
