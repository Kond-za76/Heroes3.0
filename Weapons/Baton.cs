using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Baton : Weapon
    {
        private const int FullCondition = 10;
        protected int ArmsDamage { get; init; }
        public int Condition { get; set; }

        public Baton()
        {
            WeaponType = "Ближний бой";
            ArmsDamage = 1;
            Condition = 10;

        }
        public override string Kick()
        {
            return "Бум по башке!";
        }

        public override string Repair()
        {
            return "С ума сошел...палку ремонтировать! Всегда есть палка под ногами!";
        }
    }
}
