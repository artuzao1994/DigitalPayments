using DigitalPayments.Application.Absctractions;
using DigitalPayments.Domain.Entities;
using DigitalPayments.Infraestructure.Abstractions;
using DigitalPayments.Infraestructure.Repositories;

namespace DigitalPayments.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomer (int customerId)
        {
            return _customerRepository.GetCustomer(customerId);
        }
        public void UpdateCustomer(Customer customer, Card card)
        {
            _customerRepository.UpdateCustomer(customer, card);
        }
    }
}
