using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex5
{
    public class Car
    {
        public string VinNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public string Infomation() => $"Марка машины: {Brand}\nМодель: {Model}\nГод выпуска: {Year}\nЦвет: {Colour}\nВин-номер двигателя: {VinNum}";


        public string IsVinNumCorrect(string num)
        {
            if (num == VinNum)
            {
                return $"Номер {num} содержится в структуре";
            }
            else
            {
                return $"Номер {num} не содержится в структуре";
            }
        }


        public Car(string vinNum, string brand, string model, int year, string colour)
        {
            VinNum = vinNum;
            Brand = brand;
            Model = model;
            Year = year;
            Colour = colour;
        }
    }
}
