using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class EditorInvoker
    {
        private readonly Stack<ICommand> _history = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                ICommand command = _history.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("История пуста, отменять нечего.");
            }
        }
    }
}

