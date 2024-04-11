using System;

namespace DigitalPayments.Domain.Entities
{
    public class Customer
    {  
        public Customer(int customerId, string name)
        {
            this.CustomerId = customerId;
            this.Name = name;
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Card Card { get; set; }
    }
}