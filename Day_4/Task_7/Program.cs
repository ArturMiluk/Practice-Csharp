using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main()
        {
            double celsiusValue = 25.0;
            double fromCelsius = CelsiusToFahrenheit(celsiusValue);
            Console.WriteLine($"Цельсий {celsiusValue}°C = {fromCelsius:F1}°F");

            double kelvinValue = 298.15;
            double fromKelvin = KelvinToFahrenheit(kelvinValue);
            Console.WriteLine($"Кельвин {kelvinValue}K = {fromKelvin:F1}°F");

            Console.ReadKey();
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double KelvinToFahrenheit(double kelvin)
        {
            var celsius = kelvin - 273.15;

            return CelsiusToFahrenheit(celsius);
        }
    }

}
