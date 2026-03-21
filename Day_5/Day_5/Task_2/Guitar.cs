using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Guitar : Instrument, IStringInstrument
    {
        public Guitar(string name) => Name = name;

        public override void Sound() => Console.WriteLine($"{Name} издаёт мелодичный звук.");

        public void PlayStrings() => Console.WriteLine($"{Name}: Перебор струн.");
    }
}

