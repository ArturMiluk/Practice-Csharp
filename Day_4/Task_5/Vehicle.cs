using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public abstract class Vehicle
    {
        public abstract void Move();

        public virtual void Stop()
        {
            Console.WriteLine("Транспортное средство останавливается.");
        }
    }
}

