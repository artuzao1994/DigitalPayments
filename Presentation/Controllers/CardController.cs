using Microsoft.AspNetCore.Mvc;
using DigitalPayments.Domain.Entities;
using DigitalPayments.Presentation.ViewModels;
using DigitalPayments.Application.Services;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net;
using DigitalPayments.Application.Absctractions;


namespace DigitalPayments.Presentation.Controllers
{ 
    [ApiController]
    [Route("api/v1/card")]
    public class CardController : Controller
    {
        private readonly ICardService _cardService;
        private readonly ICustomerService _customerService;
        
        public CardController (ICardService cardService, ICustomerService customerService)
        {
            _cardService = cardService;
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult Create(CardViewModel cardView, int customerId)
        {
            Customer customer = _customerService.GetCustomer(customerId);

            if (customer == null)
            {  
                return NotFound();
            }

            Card card = _cardService.ProcessCard(new Card() { Number = cardView.Number, CVV = cardView.CVV});

            if (card == null)
            {  
                return BadRequest();
            }

            _customerService.UpdateCustomer(customer, card);

            return Ok(card.Token);
        }
    }
}
