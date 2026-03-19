using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public partial class Car
    {
        public override string ToString()
        {
            return $"{Brand} {Model} ({Year} г.), Пробег: {Mileage} км";
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
