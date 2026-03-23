using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class TemperatureSensor
    {
        public event TemperatureHandler TemperatureChanged;

        public void MonitorTemperature(double newTemperature)
        {
            Console.WriteLine($"Датчик - Текущая температура: {newTemperature}°C");

            TemperatureChanged?.Invoke(newTemperature);
        }
    }
}
