using System;
using Weapons;
using Heroes;
using CLI;

namespace Heroes.App
{
    internal class Program
    {
        static void Main()
        {
            Axe axe = new Axe();
            Orc orc=new Orc("Вася",axe);
            UseHero.ToHealHero(orc);

        }
    }
}

