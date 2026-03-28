using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var editor = new TextEditor();

            var invoker = new EditorInvoker();

            Console.WriteLine($"Текущий текст: {editor.Content}\n");

            invoker.ExecuteCommand(new CopyCommand(editor));
            invoker.ExecuteCommand(new PasteCommand(editor));
            invoker.ExecuteCommand(new PasteCommand(editor));

            Console.WriteLine("\nПроверка отмены:");
            invoker.Undo();
            invoker.Undo();

            Console.ReadKey();
        }
    }
}
