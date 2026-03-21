using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Drum : Instrument, IPercussionInstrument
    {
        public Drum(string name) => Name = name;

        public override void Sound() => Console.WriteLine($"{Name} издаёт ритмичный грохот.");

        public void Strike() => Console.WriteLine($"{Name}: Удар палочками по мембране.");
    }
}

