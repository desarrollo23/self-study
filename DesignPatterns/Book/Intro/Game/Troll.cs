using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public class Troll : Character
    {
        public Troll()
        {
            weaponBehavior = new AxeBehavior();
        }
        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}
