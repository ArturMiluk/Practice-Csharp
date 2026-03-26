using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class LogEntry
    {
        public DateTime Date {get; set;}
        public string Message {get; set;}

        public LogEntry(string message)
        {
            Date = DateTime.Now;
            Message = message;
        }
    }
}

