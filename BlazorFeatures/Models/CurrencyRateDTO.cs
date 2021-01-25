using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CurrencyRateDTO
    {
        public string Table { get; set; }
        public string No { get; set; }
        public DateTime EffectiveDate { get; set; }
        public Rates[] Rates { get; set; }
    }

    public class Rates
    {
        public string Currency { get; set; }
        public string Code { get; set; }
        public double Mid { get; set; }
    }
}
