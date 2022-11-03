using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Axe : Weapon
    {
        private const int FullCondition = 20;
        protected int ArmsDamage { get; init; }
        public int Condition { get; set; }

        public Axe()
        {
            WeaponType = "Ближний бой";
            ArmsDamage = 5;
            Condition = 20;
        }

        public override string Kick()
        {
            Condition--;
            return "Ххряяссь!";
        }

        public override string Repair()
        {
            Condition=FullCondition;
            return "Готов топорик! Смотри профиль товарища Сталина вытравил на металле!";
        }
    }
}
