using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsRefOut
{
    public class Calculator
    {
        public static int Triple(ref int x)
        {
            x = x * 3;
            return x;
        }
    }
    
}