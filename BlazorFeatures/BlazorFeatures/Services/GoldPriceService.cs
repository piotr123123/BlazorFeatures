using Microsoft.AspNetCore.Components;
using Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorFeatures.Services
{
    public class GoldPriceService : IGoldPrice
    {
        private readonly HttpClient httpClient;

        public GoldPriceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public GoldPriceService()
        {

        }
        public async Task<IEnumerable<GoldPrice>> GetGoldPrice()
        {
            return await httpClient.GetJsonAsync<GoldPrice[]>("api/cenyzlota?format=json");

        }

        public Tuple<HttpStatusCode, GoldPrice[]> GetGoldPrice1()
        {
            var client = new RestClient("http://api.nbp.pl/api");

            var request1 = new RestRequest("/cenyzlota?format=json", Method.GET);
            
            request1.RequestFormat = DataFormat.Json;
            request1.AddHeader("Accept", "application/json");

            IRestResponse response = null;
            //get status code
            response = client.Execute(request1);
            HttpStatusCode respstatus = response.StatusCode;
            string responseText = null;
            responseText = response.Content;

            GoldPrice[] call = JsonConvert.DeserializeObject<GoldPrice[]>(responseText);
            double wynik = call[0].cena;
            return new Tuple<HttpStatusCode, GoldPrice[]>(respstatus, call);
        }
    }
}
