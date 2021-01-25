using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CurrencyRateCollectionDTO
    {
        public string Currency { get; set; }
        public string Code { get; set; }
        public double Mid { get; set; }

        public CurrencyRateCollectionDTO(string Currency, string Code, double Mid)
        {
            this.Currency = Currency;
            this.Code = Code;
            this.Mid = Mid;
        }
    }
}
