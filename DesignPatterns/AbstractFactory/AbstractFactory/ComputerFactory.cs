using DesignPatterns.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public abstract class ComputerFactory
    {
        public abstract Laptop CreateLaptop();
        public abstract Desktop CreateDesktop();
    }
}
