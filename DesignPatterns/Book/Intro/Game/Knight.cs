using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public class Knight : Character
    {
        public Knight()
        {
            weaponBehavior = new BowAndArrowBehavior();
        }
        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}
