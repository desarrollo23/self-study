using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.Cryptocurrency
{
    public interface IInvestor
    {
        void Update(CryptoCurrency cryptoCurrency);
    }
}
