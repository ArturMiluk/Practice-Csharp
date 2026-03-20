using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main()
        {
            Vehicle[] vehicles = { new Car(), new Bicycle() };

            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
                vehicle.Stop();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

