using DigitalPayments.Domain.Entities;

namespace DigitalPayments.Infraestructure.Abstractions
{
    public interface IProviderService
    {
        public string ProcessCard(Card card);
        public string ProcessMethod(string input);
        public string ProcessMethod(Card card);
    }
}
