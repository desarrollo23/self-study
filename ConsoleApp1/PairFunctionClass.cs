using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class PairFunctionClass
    {
        public static int[][] PairFunction(int[] inputArray, int targetNumber)
        {
            int[][] result = new int[0][];
            var indexResult = 0;

            for (int index = 0; index < inputArray.Length; index++)
            {
                // IMPLEMENT YOUR CODE HERE
                int sum = inputArray[index];
                for (int index2 = index + 1; index2 < inputArray.Length; index2++)
                {
                    sum +=  inputArray[index2];

                    if(sum == targetNumber)
                    {
                        Array.Resize(ref result, indexResult + 1);
                        result[indexResult] = new int[] { inputArray[index], inputArray[index2] };
                        indexResult++;
                    }

                    sum = inputArray[index];
                }
            }

            return result;
        }
    }
}
