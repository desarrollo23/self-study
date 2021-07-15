using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            int total = 0;

            var splitted = numbers.Split(",");

            foreach (var number in splitted)
            {
                int.TryParse(number, out int numberInt);

                if(numberInt < 0)
                    throw new ArgumentException($"Negative numbers not allowed: {numberInt}");

                if (numberInt <= 1000)
                    total += numberInt;
            }

            return total;
        }
    }
}
