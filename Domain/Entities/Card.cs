using DigitalPayments.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace DigitalPayments.Domain.Entities
{
    public class Card 
    {
        [Key]
        public int Id { get; set; }
        public string Number {  get; set; }
        public int CVV { get; set; }
        public CardType Type { get; set; }
        public string Token { get; set; }
    }
}
