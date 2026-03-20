using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public static class ArrayExtensions
    {
        public static int SumElements(this int[] array)
        {
            var sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }

            return sum;
        }
    }
}
