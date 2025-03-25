using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex1
{
    public class Auto : ITransport
    {
        private static readonly string _transportType = "Автомобиль";
        public string Type => _transportType;


        private static readonly double _rentPrice = 50;
        public double RentPrice => _rentPrice;

        public string AutoNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
    }
}
