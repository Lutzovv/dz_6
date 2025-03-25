using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex2
{
    public interface IWeapon
    {
        static string WeaponType { get; }
        int WeaponStrenght { get; set; }
        string SpecialWeaponFeatures { get; set; }
    }
}
