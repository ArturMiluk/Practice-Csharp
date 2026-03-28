using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class TextEditor
    {
        public string Clipboard {get; set;} = string.Empty;
        public string Content {get; set;} = "Текст";

        public void Copy()
        {
            Clipboard = Content;
            Console.WriteLine($"Текст '{Clipboard}' скопирован в буфер.");
        }

        public void Paste()
        {
            Content += $" {Clipboard}";
            Console.WriteLine($"Текст из буфера вставлен. Текущий контент: {Content}");
        }
    }
}


