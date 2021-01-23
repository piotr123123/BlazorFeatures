using BlazorFeatures.Services;
using Microsoft.AspNetCore.Components;
using Models;
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
        public List<GoldPriceDTO> GoldPriceColletcion = new List<GoldPriceDTO>();
        public string Message { get; set; } = "Cena złota rośnie w góre";

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(CenaZlota111);
            //Wynik = GoldPriceService.GetGoldPrice1().Item2[0].cena; 
        }

        public double CenaZlota()
        {
            var cena = GoldPriceService.GetGoldPrice1().Item2[0].cena;
            return cena;
        }

        public async Task CenaZlota111()
        {
            GoldPriceColletcion = (await GoldPriceService.GetGoldPrice()).ToList();
                       
        }
    }
}
