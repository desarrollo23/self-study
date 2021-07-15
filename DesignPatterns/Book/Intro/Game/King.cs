using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public class King : Character
    {
        public King()
        {
            weaponBehavior = new SwordBehavior();
        }

        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}
