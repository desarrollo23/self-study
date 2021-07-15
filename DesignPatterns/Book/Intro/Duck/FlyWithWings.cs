using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Duck
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
