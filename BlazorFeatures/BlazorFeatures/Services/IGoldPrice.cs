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
        Task<IEnumerable<GoldPrice>> GetGoldPrice();
        public Tuple<HttpStatusCode, GoldPrice[]> GetGoldPrice1();
    }
}
