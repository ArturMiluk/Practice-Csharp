using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class LogProcessor
    {
        public static List<LogEntry> FilterLogsByDate(List<LogEntry> logs, DateTime fromDate, DateTime toDate)
        {
            return logs
                .Where(log => log.Date >= fromDate && log.Date <= toDate)
                .ToList();
        }
    }
}

