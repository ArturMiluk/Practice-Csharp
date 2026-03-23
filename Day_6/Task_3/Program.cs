using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var sensor = new TemperatureSensor();
            var cooler = new CoolingSystem();
            var alarm = new WarningSystem();

            sensor.TemperatureChanged += cooler.OnTemperatureChanged;
            sensor.TemperatureChanged += alarm.OnTemperatureChanged;

            sensor.MonitorTemperature(20.0);
            Console.WriteLine();

            sensor.MonitorTemperature(28.5);
            Console.WriteLine();

            sensor.MonitorTemperature(40.0);

            Console.ReadKey();
        }
    }
}
