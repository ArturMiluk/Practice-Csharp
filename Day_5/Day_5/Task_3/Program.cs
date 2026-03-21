using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            var s1 = new Student("Роман");
            var s2 = new Student("Богдан ");
            var prof = new Professor("Артур");

            University[] universities =
            {
                new University("БГУ", "ФПМИ", new[] { s1, s2 }),
                new University("БНТУ", "АТФ", new[] { new Student("Егор")}
            )
        };

            universities[0].AssignProfessor(prof);

            foreach (var uni in universities)
            {
                uni.ShowInfo();
            }

            Console.ReadKey();
        }
    }
}
