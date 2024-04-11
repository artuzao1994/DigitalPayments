using DigitalPayments.Domain.Entities;
using DigitalPayments.Infraestructure.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace DigitalPayments.Infraestructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private static readonly List<Customer> customersFromMemory = new List<Customer>() {

            new Customer(1, "José"),
            new Customer(2, "Diego"),
            new Customer(3, "Maria"),
            new Customer(4, "João"),
        };

        public Customer GetCustomer(int customerId)
        {
            try
            {
                return customersFromMemory.Where(x => x.CustomerId == customerId).FirstOrDefault();
            }
            catch (System.Exception)
            {
                return null;
            }          
        }

        public void UpdateCustomer(Customer customer, Card card)
        {
           //TODO
        }
    }
}
