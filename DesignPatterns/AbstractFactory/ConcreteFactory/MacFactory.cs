using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.AbstractFactory.ConcreteProduct.Mac;
using System;

namespace DesignPatterns.AbstractFactory.ConcreteFactory
{
    public class MacFactory : ComputerFactory
    {
        public override Desktop CreateDesktop()
        {
            return new IMac();
        }

        public override Laptop CreateLaptop()
        {
            return new MacBookAir();
        }
    }
}
