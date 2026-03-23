using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class CoolingSystem
    {
        public void OnTemperatureChanged(double temperature)
        {
            if (temperature > 25.0)
            {
                Console.WriteLine("Охлаждение - Температура выше 25°C. Кондиционер включен.");
            }
            else
            {
                Console.WriteLine("Охлаждение - Температура в норме. Кондиционер выключен.");
            }
        }
    }
}

