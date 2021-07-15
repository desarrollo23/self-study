using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Duck
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
