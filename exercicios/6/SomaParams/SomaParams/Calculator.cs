using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaParams
{
    public class Calculator
    {
        public static double Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length ; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
