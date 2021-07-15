using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Katas
{
    public class WeightForWeight
    {
        public static string OrderWeight(string strng)
        {
            var splittedNumbers = strng.Split(" ");

            var result = ValidateNumbers(splittedNumbers, splittedNumbers.Length);

            return string.Join(" ", result);
        }

        public static string[] ValidateNumbers(string[] array, int len)
        {
            if (len == 1) return array;
            for (int index = 0; index < len - 1; index++)
            {
                int.TryParse(array[index], out int currentNumber);
                int.TryParse(array[index + 1], out int nextNumber);

                var currentNumberSum = SumDigits(currentNumber);
                var nextNumberSum = SumDigits(nextNumber);

                if (currentNumberSum > nextNumberSum)
                {
                    string aux = array[index];
                    array[index] = array[index + 1];
                    array[index + 1] = aux;
                }
            }

            ValidateNumbers(array, len - 1);

            return array;
        }
        public static int SumDigits(int number)
        {
            int sum = 0, m;

            while (number > 0)
            {
                m = number % 10;
                sum += m;

                number = number / 10;
            }

            return sum;
        }

    }
}
