using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            var editor = new GraphicEditor();

            Console.WriteLine("Вызов методов через интерфейсы:");

            IDraw drawer = editor;
            drawer.ApplyColor("Синий");

            IPaint painter = editor;
            painter.ApplyColor("Зеленый");

            ((IDraw)editor).ApplyColor("Чёрный");
            ((IPaint)editor).ApplyColor("Белый");

            Console.ReadKey();
        }
    }
}
