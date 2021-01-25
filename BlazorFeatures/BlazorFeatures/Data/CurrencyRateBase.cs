using BlazorFeatures.Services;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFeatures.Data
{
    public class CurrencyRateBase : ComponentBase
    {
        public IEnumerable<CurrencyRateDTO> RateCollection { get; set; }

        public List<CurrencyRateCollectionDTO> CurrencyRateList = new List<CurrencyRateCollectionDTO>();

        [Inject]
        public ICurrencyRate CurrencyRate { get; set; }

        protected async override Task OnInitializedAsync()
        {
            RateCollection = (await CurrencyRate.GetListOfCurrency()).ToList();
            await Task.Run(LoadKursyWalutNew);
        }

        private async Task LoadKursyWalutNew()
        {
            var kur = RateCollection.ToList();

            for (int i = 0; i < kur[0].Rates.Length; i++)
            {
                CurrencyRateList.Add(new CurrencyRateCollectionDTO(kur[0].Rates[i].Currency, kur[0].Rates[i].Code, kur[0].Rates[i].Mid));
            }
            
        }
    }
}
