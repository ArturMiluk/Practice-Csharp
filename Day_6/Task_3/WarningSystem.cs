using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class WarningSystem
    {
        public void OnTemperatureChanged(double temperature)
        {
            if (temperature > 35.0)
            {
                Console.WriteLine("Предупреждение - Перегрев!");
            }
        }
    }
}

