using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Heroes
{
    public abstract class Hero
    {
        public string Name { get; init; }
        public string Race { get; init; }
        public int Experience { get; set; }

        public abstract string BattleCry();
        public abstract string Heal();
        
    }
    
}
