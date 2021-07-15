using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using Axe!");
        }
    }
}
