using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public abstract class Weapon
    {        
        protected string WeaponType { get; init; }
        public abstract string Kick();
        public abstract string Repair();



    }
}
