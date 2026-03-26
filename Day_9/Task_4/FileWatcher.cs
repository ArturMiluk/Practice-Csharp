using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class FileWatcher
    {
        private FileSystemWatcher _watcher;
        private const string LogPath = "log.txt";

        public FileWatcher(string directoryPath)
        {
            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

            _watcher = new FileSystemWatcher(directoryPath);

            _watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size;

            _watcher.Created += OnChanged;
            _watcher.Deleted += OnChanged;
            _watcher.Changed += OnChanged;
            _watcher.Renamed += OnRenamed;

            _watcher.EnableRaisingEvents = true;
            Console.WriteLine($"Папка {directoryPath} под наблюдением.");
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            LogAction($"Тип: {e.ChangeType}, Файл: {e.Name}");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            LogAction($"Переименован: {e.OldName} -> {e.Name}");
        }

        private void LogAction(string message)
        {
            string logLine = $"[{DateTime.Now:G}] {message}";
            Console.WriteLine(logLine);
            try
            {
                File.AppendAllText(LogPath, logLine + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи лога: {ex.Message}");
            }
        }
    }
}

