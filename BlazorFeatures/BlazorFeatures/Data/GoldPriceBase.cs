using BlazorFeatures.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlazorFeatures.Data
{
    public class GoldPriceBase : ComponentBase
    {
        [Inject]
        public IGoldPrice GoldPriceService { get; set; }
        public double Wynik { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //Wynik = GoldPriceService.GetGoldPrice1().Item2[0].cena; 
        }

        public double CenaZlota()
        {
            var cena = GoldPriceService.GetGoldPrice1().Item2[0].cena;

            return cena;
        }
    }
}
