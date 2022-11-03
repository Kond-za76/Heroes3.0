using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Weapons;

namespace Heroes
{
    internal class Elf:Hero
    {
        public int[] Health { get; set; }//[0]-значение полного здоровья, [1]-текущее здоровье
        public Weapon Arms { get; set; }
        


        public Elf(string name, Weapon weapon)
        {
            Name = name;
            Arms = weapon;
            Race = "Эльф";
            Health[0] = 100;
            Health[1] = 100;
            Experience = 0;
        }

        public override string BattleCry()
        {
            return "Никто не устоит против хитрого эльфа!";
        }
        public override string Heal()
        {
            Health[1] = Health[0] = 120;
            return "Здоров как бык!";
        }
    }
}
