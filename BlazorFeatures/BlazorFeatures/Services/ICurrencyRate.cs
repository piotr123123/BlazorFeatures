using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFeatures.Services
{
    public interface ICurrencyRate
    {
        Task<IEnumerable<CurrencyRateDTO>> GetListOfCurrency();
    }
}
