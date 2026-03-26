using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class LogFileReader
    {
        private const string FilePath = "milukaa.data";

        public static List<LogEntry> ReadLogs()
        {
            List<LogEntry> logs = new List<LogEntry>();

            if (!File.Exists(FilePath)) return logs;

            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { " | " }, StringSplitOptions.None);

                if (parts.Length == 2)
                {
                    if (DateTime.TryParse(parts[0], out DateTime date))
                    {
                        logs.Add(new LogEntry(date, parts[1]));
                    }
                }
            }
            return logs;
        }
    }
}

