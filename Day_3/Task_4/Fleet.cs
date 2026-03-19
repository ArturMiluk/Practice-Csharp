using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Fleet
    {
        private readonly Car[] _cars;

        public Fleet(Car[] cars)
        {
            _cars = cars ?? Array.Empty<Car>();
        }

        public Car[] GetNewestCars(int year)
        {
            return _cars.Where(c => c.Year > year).ToArray();
        }

        public Car[] GetCarsByBrand(string brand)
        {
            return _cars
                .Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                .ToArray();
        }

        public void ShowAll()
        {
            foreach (var car in _cars) car.DisplayInfo();
        }
    }
}
