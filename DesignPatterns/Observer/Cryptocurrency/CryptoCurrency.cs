using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.Cryptocurrency
{
    public abstract class CryptoCurrency
    {
        private string symbol;
        private double price;

        private List<IInvestor> investors = new List<IInvestor>();

        public CryptoCurrency(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Dettach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notity()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price 
        {
            get { return price; } 
            set
            {
                if(price != value)
                {
                    price = value;
                    Notity();
                }
            }
        }

        public string Symbol 
        {
            get { return symbol; }
        }
    }
}
