using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public class Queen : Character
    {
        public Queen()
        {
            weaponBehavior = new SwordBehavior();
        }
        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}
