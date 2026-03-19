using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Calculator
    {
        public int AValue {get;}
        public int BValue {get;}

        public Calculator(int a, int b)
        {
            AValue = a;
            BValue = b;
        }

        public long CalculateProduct()
        {
            return (long)AValue * BValue;
        }

        public double CalculateExpression()
        {
            if (AValue == 0)
            {
                return double.NaN;
            }

            if (BValue < 0)
            {
                return double.NaN;
            }

            return Math.Sqrt(BValue) / (2.0 * AValue);
        }
    }
}
