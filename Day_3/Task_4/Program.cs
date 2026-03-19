using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Car[] carData =
            [
            new Car("BMW", "M5", 2021, 22000),
            new Car("BMW", "X7", 2022, 10000),
            new Car("Tesla", "Model S", 2020, 40000),
            new Car("Audi", "A6", 2019, 75000)
            ];

            Fleet myFleet = new Fleet(carData);

            Console.WriteLine("Все машины:");
            myFleet.ShowAll();

            Console.WriteLine("\nМашины новее 2021 года:");
            var newCars = myFleet.GetNewestCars(2021);
            foreach (var car in newCars) car.DisplayInfo();

            string searchBrand = "Audi";
            Console.WriteLine($"\nПоиск автомобилей марки {searchBrand}:");
            var brandCars = myFleet.GetCarsByBrand(searchBrand);
            foreach (var car in brandCars) car.DisplayInfo();

            Console.ReadKey();
        }
    }
}
