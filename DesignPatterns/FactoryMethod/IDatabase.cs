using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public interface IDatabase
    {
        void Connect();
        void Open();

        void Close();
    }
}
