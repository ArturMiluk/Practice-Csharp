using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Company
    {
        private readonly Employee[] _employees;

        public Company(Employee[] employees)
        {
            _employees = employees;
        }

        public Employee? GetHighestPaidEmployee()
        {
            if (_employees == null || _employees.Length == 0) return null;

            return _employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        }

        public double GetAverageAge()
        {
            if (_employees == null || _employees.Length == 0) return 0;

            return _employees.Average(e => e.Age);
        }

        public void ShowAllEmployees()
        {
            foreach (var emp in _employees)
            {
                System.Console.WriteLine(emp);
            }
        }
    }
}