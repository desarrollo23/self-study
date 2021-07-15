using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using Sword!");
        }
    }
}
