using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class CopyCommand : ICommand
    {
        private readonly TextEditor _editor;

        public CopyCommand(TextEditor editor) => _editor = editor;

        public void Execute() => _editor.Copy();

        public void Undo() => Console.WriteLine("Копирование нельзя отменить (состояние буфера сохранено).");
    }
}

