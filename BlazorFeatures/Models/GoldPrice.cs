using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class GoldPrice
    {
        public DateTime data { get; set; }
        public double cena { get; set; }

        public GoldPrice(DateTime dateTime, double cena)
        {
            this.data = dateTime;
            this.cena = cena;
        }

        public GoldPrice()
        { 
        
        }
    }
}
