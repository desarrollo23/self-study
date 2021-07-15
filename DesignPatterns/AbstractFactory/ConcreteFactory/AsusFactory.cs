using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.AbstractFactory.ConcreteProduct.Asus;

namespace DesignPatterns.AbstractFactory.ConcreteFactory
{
    public class AsusFactory : ComputerFactory
    {
        public override Desktop CreateDesktop()
        {
            return new AsusZenAio();
        }

        public override Laptop CreateLaptop()
        {
            return new ZenBook();
        }
    }
}
