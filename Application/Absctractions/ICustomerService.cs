using DigitalPayments.Domain.Entities;
using DigitalPayments.Infraestructure.Repositories;

namespace DigitalPayments.Application.Absctractions
{
    public interface ICustomerService
    {
        public Customer GetCustomer(int customerId);
        public void UpdateCustomer(Customer customer, Card card);
    }
}
