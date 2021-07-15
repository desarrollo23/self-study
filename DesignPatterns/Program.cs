using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.ConcreteFactory;
using DesignPatterns.AbstractFactory.Handler;
using DesignPatterns.Book.Intro.Duck;
using DesignPatterns.Book.Intro.Game;
using DesignPatterns.FactoryMethod;
using DesignPatterns.FactoryMethod.Handlers;
using DesignPatterns.Observer.Cryptocurrency;
using System;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Method
            //DatabaseFactory dbFactory = DatabaseObjectHandler.GetDatabase();
            //var db = dbFactory.CreateObject();


            // Abstract Factory

            //ComputerFactory factory = new LenovoFactory();
            //ComputerHandler computerHandler = new ComputerHandler(factory);

            //Console.WriteLine(@$"De la fabrica {factory.GetType().Name}, se creo el desktop {computerHandler.Desktop.GetType().Name}, y laptop {computerHandler.Laptop.GetType().Name}");

            //Console.ReadLine();

            ////INTRO DUCK SIMULATOR

            //Duck mallard = new MallarDuck();
            //mallard.PerformQuack();
            //mallard.PerformFly();
            //mallard.Swim();

            //Duck model = new ModelDuck();
            //model.PerformFly();
            //model.SetFlyBehavior(new FlyRocketPowered());
            //model.PerformFly();

            //Design Puzzle

            //Character character = new Queen();
            //character.Fight();

            //character.SetWeapon(new BowAndArrowBehavior());
            //character.Fight();

            //character.SetWeapon(new AxeBehavior());
            //character.Fight();

            // OBSERVER
            Bitcoin bitcoin = new Bitcoin("Bitcoin", 120.00);
            bitcoin.Attach(new Investor("Andres Duarte"));
            bitcoin.Attach(new Investor("Natalia Guarin"));

            // Fluctuating prices will notify investors
            bitcoin.Price = 120.10;
            bitcoin.Price = 121.00;
            bitcoin.Price = 120.50;
            bitcoin.Price = 120.75;

            Console.ReadLine();
        }
    }
}
