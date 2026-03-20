using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Велосипед едет.");
        }

        public override void Stop()
        {
            Console.WriteLine("Велосипед останавливается: педали заблокированы.");
        }
    }
}

