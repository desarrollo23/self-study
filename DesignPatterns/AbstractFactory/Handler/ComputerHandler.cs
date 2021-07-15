using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Handler
{
    public class ComputerHandler
    {
        private Desktop _desktop;
        private Laptop _laptop;

        public ComputerHandler(ComputerFactory factory)
        {
            _desktop = factory.CreateDesktop();
            _laptop = factory.CreateLaptop();
        }

        public Desktop Desktop
        {
            get { return _desktop; }
            set { _desktop = value; }
        }

        public Laptop Laptop
        {
            get { return _laptop; }
            set { _laptop = value; }
        }

    }
}
