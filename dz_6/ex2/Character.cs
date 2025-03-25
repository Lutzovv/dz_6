using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex2
{
    public class Character<T> where T : IWeapon
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public T Weapon { get; set; }
        public int Strength { get; set; }

        public string Infomation() => $"Имя: {Name}\nРаса: {Race}\nОружие: {Weapon}\nСила персонажа: {Strength}\nСила персонажа вместе с оружием: {Strength + Weapon.WeaponStrenght}";
    }
}
