using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public abstract class Employee
    {
        public string Name {get;}
        public int Age {get;}
        public decimal Salary {get;}

        protected Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public abstract string GetPosition();

        public override string ToString() =>
            $"[{GetPosition()}] {Name}, Возраст: {Age}, Зарплата: {Salary:C0}";
    }
}
