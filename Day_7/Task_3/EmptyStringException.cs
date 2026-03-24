using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException() : base("Строка не может быть пустой или содержать только пробелы.") { }

        public EmptyStringException(string message) : base(message) { }

        public EmptyStringException(string message, Exception inner) : base(message, inner) { }
    }
}

