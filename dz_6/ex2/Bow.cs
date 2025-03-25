using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex2
{
    public class Bow
    {
        public string WeaponType => _type;
        private static readonly string _type = "Лук";

        public double Distance { get; set; }
        public double Accuracy { get; set; }

        public int WeaponStrenght { get; set; }
        public string SpecialWeaponFeatures { get; set; }
    }
}
