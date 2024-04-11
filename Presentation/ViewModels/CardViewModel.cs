using DigitalPayments.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DigitalPayments.Presentation.ViewModels
{
    public class CardViewModel
    {
        public string Number { get; set; }
        public int CVV { get; set; }
        public CardType Type { get; set; }
    }
}
