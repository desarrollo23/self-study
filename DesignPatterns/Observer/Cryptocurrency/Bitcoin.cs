using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.Cryptocurrency
{
    public class Bitcoin : CryptoCurrency
    {
        public Bitcoin(string symbol, double price): base(symbol, price)
        {
        }
    }
}
