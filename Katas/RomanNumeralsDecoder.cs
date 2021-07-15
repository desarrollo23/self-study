using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Katas
{
    public class RomanNumeralsDecoder
    {
        public static int Solution(string roman)
        {
            var total = 0;
            var dictionary = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 }
            };

            var number = roman.Select(x => x.ToString().ToUpper()).ToList();

            var previousNumber = 0;

            foreach (var digit in number)
            {
                if (previousNumber > 0 && previousNumber < dictionary[digit])
                {
                    total = total - (previousNumber * 2) + dictionary[digit];
                    continue;
                }
                    
                total += dictionary[digit];
                previousNumber = dictionary[digit];
            }

            return total;
        }
    }
}
