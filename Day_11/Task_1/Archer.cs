using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Archer : ICharacter
    {
        public void Attack() => Console.WriteLine("Лучник стреляет из лука");
    }
}

