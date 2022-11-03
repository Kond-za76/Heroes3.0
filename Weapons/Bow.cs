using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Bow : Weapon
    {
        private const int FullCondition = 10;
        protected int ArmsDamage { get; init; }
        public int Condition { get; set; }


        public Bow()
        {
            WeaponType = "Дистанция";
            ArmsDamage = 3;
            Condition = 10;
            
        }
        public override string Kick()
        {
            Condition--;
            return "Пуньк!";
        }
        public override string Repair()
        {
            Condition = FullCondition;
            return "Натянул титеву тебе новую из волос Моровиндских девственниц!";
        }
    }
}
