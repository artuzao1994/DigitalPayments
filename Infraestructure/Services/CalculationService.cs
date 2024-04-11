using DigitalPayments.Domain.Entities;
using DigitalPayments.Infraestructure.Abstractions;
using System;
using System.Linq;

namespace DigitalPayments.Infraestructure.Services
{
    public class CalculationService : ICalculationService
    {
        public string GenerateTokenByMD5(string input)
        {
            var hash = System.Security.Cryptography.MD5.Create()
                .ComputeHash(System.Text.Encoding.ASCII.GetBytes(input ?? ""));
            return string.Join("", Enumerable.Range(0, hash.Length).Select(i => hash[i].ToString("x2")));
        }

        public string GenerateTokenByCircularRotation(Card card)
        {
            string tokenString = card.Number.Substring(card.Number.Length - 4);
            int[] tokenIntArray = tokenString.Split(';').Select(n => Convert.ToInt32(n)).ToArray();

            var result = new int[tokenIntArray.Length];

            for (int i = 0; i < tokenIntArray.Length; ++i)
            {
                int j = (i + card.CVV) % tokenIntArray.Length;
                result[j] = tokenIntArray[i];
            }

            return result.ToString();
        }
    }
}
