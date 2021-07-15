using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.Cryptocurrency
{
    public class Investor : IInvestor
    {
        private string name;
        private CryptoCurrency cryptoCurrency;

        public CryptoCurrency CryptoCurrency
        {
            get { return cryptoCurrency; }
            set { cryptoCurrency = value; }
        }

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(CryptoCurrency cryptoCurrency)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", name, cryptoCurrency.Symbol, cryptoCurrency.Price);
        }
    }
}
