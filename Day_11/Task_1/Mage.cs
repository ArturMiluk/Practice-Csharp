using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Mage : ICharacter
    {
        public void Attack() => Console.WriteLine("Маг выпускает магический снаряд");
    }
}

