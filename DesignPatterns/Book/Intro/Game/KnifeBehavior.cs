using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using Knike!");
        }
    }
}
