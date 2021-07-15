using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Duck
{
    public class MallarDuck: Duck
    {
        public MallarDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
