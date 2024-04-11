using DigitalPayments.Domain.Entities;

namespace DigitalPayments.Infraestructure.Abstractions
{
    public interface ICustomerRepository
    {
        public Customer GetCustomer(int customerId);
        public void UpdateCustomer(Customer customer, Card card);
    }
}
