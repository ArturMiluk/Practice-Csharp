using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class LogEntry
    {
        public DateTime Date {get; set;}
        public string Message {get; set;}

        public LogEntry(DateTime date, string message)
        {
            Date = date;
            Message = message;
        }
    }
}

