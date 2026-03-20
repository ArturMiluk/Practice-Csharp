using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Автомобиль едет.");
        }

        public override void Stop()
        {
            Console.WriteLine("Автомобиль останавливается: нажаты тормоза.");
        }
    }
}

