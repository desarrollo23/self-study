using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Duck
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}
