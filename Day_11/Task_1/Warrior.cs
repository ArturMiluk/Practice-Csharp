using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Warrior : ICharacter
    {
        public void Attack() => Console.WriteLine("Воин рубит мечом");
    }
}

