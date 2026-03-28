using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class MageFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter() => new Mage();
    }
}

