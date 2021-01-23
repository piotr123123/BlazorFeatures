using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class GoldPriceDTO
    {
        public DateTime data { get; set; }
        public double cena { get; set; }

        public GoldPriceDTO(DateTime dateTime, double cena)
        {
            this.data = dateTime;
            this.cena = cena;
        }

        public GoldPriceDTO()
        { 
        
        }
    }
}
