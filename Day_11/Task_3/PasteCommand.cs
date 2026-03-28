using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class PasteCommand : ICommand
    {
        private readonly TextEditor _editor;
        private string _previousContent;

        public PasteCommand(TextEditor editor) => _editor = editor;

        public void Execute()
        {
            _previousContent = _editor.Content;
            _editor.Paste();
        }

        public void Undo()
        {
            _editor.Content = _previousContent;
            Console.WriteLine($"Вставка отменена. Контент возвращен к: {_editor.Content}");
        }
    }
}

