using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Program
    {
        public static void Main()
        {
            var factories = new List<CharacterFactory>
            {
                new WarriorFactory(),
                new MageFactory(),
                new ArcherFactory()
            };

            Console.WriteLine("Генерация отряда персонажей\n:");

            foreach (var factory in factories)
            {
                ICharacter character = factory.CreateCharacter();
                character.Attack();
            }

            Console.ReadKey();
        }
    }
}


