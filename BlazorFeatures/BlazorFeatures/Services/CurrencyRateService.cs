using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorFeatures.Services
{
    public class CurrencyRateService : ICurrencyRate
    {
        private readonly HttpClient httpClient;
        public CurrencyRateService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public CurrencyRateService()
        {

        }
        public async Task<IEnumerable<CurrencyRateDTO>> GetListOfCurrency()
        {
            return await httpClient.GetJsonAsync<CurrencyRateDTO[]>("api/exchangerates/tables/a/?format=json");
        }
    }
}
