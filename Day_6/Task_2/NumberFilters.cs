using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class NumberFilters
    {
        public static bool IsEven(int number) => number % 2 == 0;

        public static bool IsOdd(int number) => number % 2 != 0;
    }
}

