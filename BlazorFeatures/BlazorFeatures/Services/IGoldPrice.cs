using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace BlazorFeatures.Services
{
    public interface IGoldPrice
    {
        Task<IEnumerable<GoldPriceDTO>> GetGoldPrice();
        public Tuple<HttpStatusCode, GoldPriceDTO[]> GetGoldPrice1();
    }
}
