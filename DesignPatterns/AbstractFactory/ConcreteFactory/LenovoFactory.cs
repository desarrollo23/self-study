using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.AbstractFactory.ConcreteProduct.Lenovo;

namespace DesignPatterns.AbstractFactory.ConcreteFactory
{
    public class LenovoFactory : ComputerFactory
    {
        public override Desktop CreateDesktop()
        {
            return new ThinkCentre();
        }

        public override Laptop CreateLaptop()
        {
            return new ThinkBook();
        }
    }
}
