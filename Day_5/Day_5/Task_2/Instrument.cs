using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public abstract class Instrument
    {
        public string Name {get; set;}

        public abstract void Sound();
    }
}

