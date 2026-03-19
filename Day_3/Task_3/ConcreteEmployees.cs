using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public sealed class Manager : Employee
    {
        public Manager(string name, int age, decimal salary)
            : base(name, age, salary) { }

        public override string GetPosition() => "Руководитель";
    }

    public sealed class Developer : Employee
    {
        public Developer(string name, int age, decimal salary)
            : base(name, age, salary) { }

        public override string GetPosition() => "Разработчик";
    }
}
