using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Heroes
{
    public class Orc : Hero
    {
        public int[] Health { get; set; }//[0]-значение полного здоровья, [1]-текущее здоровье
        public Weapon Arms { get; set; }     
              
        

        public Orc(string name, Weapon weapon)
        {
            int[] Health = new int[2];
            Name = name;
            Arms = weapon;
            Race = "Орк";
            Health[0] = 120;
            Health[1] = 120;
            Experience = 0;
        }

        public override string BattleCry()
        {
            return "Сейчас ты умрешь!!!";
        }
        public override string Heal()
        {
            Health[1]= Health[0];
            return "Здоров как бык!";
        }
        

    }
}
