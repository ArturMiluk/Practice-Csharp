using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public partial class Car
    {
        public string Brand {get;}
        public string Model {get;}
        public int Year {get;}
        public int Mileage {get;}

        public Car(string brand, string model, int year, int mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
    }
}
