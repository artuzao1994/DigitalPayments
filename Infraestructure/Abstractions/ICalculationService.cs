using DigitalPayments.Domain.Entities;
using System.Linq;

namespace DigitalPayments.Infraestructure.Abstractions
{
    public interface ICalculationService
    {
        public string GenerateTokenByMD5(string input);
        public string GenerateTokenByCircularRotation(Card card);
    }
}
