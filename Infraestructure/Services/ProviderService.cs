using DigitalPayments.Domain.Entities;
using System.Configuration;
using DigitalPayments.Domain.Enums;
using System;
using DigitalPayments.Infraestructure.Abstractions;

namespace DigitalPayments.Infraestructure.Services
{
    public class ProviderService : IProviderService
    {
        private readonly ICalculationService _calculationService;
        public ProviderService(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public string ProcessCard(Card card)
        {
            string token = "";
        
            try
            {
                ProviderMethod providerMethod;
                Enum.TryParse(ConfigurationManager.AppSettings.Get("ProviderMethod"), out providerMethod);

                switch (providerMethod)
                {
                    case ProviderMethod.A:
                        token = ProcessMethod(card.Number + card.CVV);
                        break;
                    case ProviderMethod.B:
                        token = ProcessMethod(card);
                        break;                 
                }
            }
            catch (System.Exception)
            {           
                return null;                
            }
            
            return token;
        }

        public string ProcessMethod(string input)
        {
            return _calculationService.GenerateTokenByMD5(input);
        }

        public string ProcessMethod(Card card)
        {
            return _calculationService.GenerateTokenByCircularRotation(card);
        }
    }
}


