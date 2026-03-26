using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class LogFileWriter
    {
        private const string FilePath = "milukaa.data";

        public static void AppendLogEntry(LogEntry entry)
        {
            try
            {
                string logLine = $"{entry.Date:G} | {entry.Message}";

                using (StreamWriter sw = new StreamWriter(FilePath, append: true))
                {
                    sw.WriteLine(logLine);
                }
                Console.WriteLine($"Запись добавлена в {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи: {ex.Message}");
            }
        }
    }
}