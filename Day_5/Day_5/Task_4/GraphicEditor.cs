using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class GraphicEditor : IDraw, IPaint
    {
        void IDraw.ApplyColor(string color)
        {
            Console.WriteLine($"IDraw: Установка цвета контура в {color}.");
        }

        void IPaint.ApplyColor(string color)
        {
            Console.WriteLine($"IPaint: Применение заливки цветом {color}.");
        }
    }
}

