using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class FileManager
    {
        public static void CreateAndWrite(string path, string text)
        {
            File.WriteAllText(path, text);
            Console.WriteLine($"Файл создан: {path}");
        }

        public static void ReadAndPrint(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine($"Содержимое {path}: {File.ReadAllText(path)}");
            }
        }

        public static void SafeDelete(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine($"Файл {path} успешно удален.");
                }
                else
                {
                    Console.WriteLine($"Удаление невозможно: файл {path} не существует.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении: {ex.Message}");
            }
        }

        public static void Copy(string source, string dest)
        {
            File.Copy(source, dest, true);
            Console.WriteLine($"Копия создана. Существование копии: {File.Exists(dest)}");
        }

        public static void MoveOrRename(string source, string dest)
        {
            if (File.Exists(source))
            {
                if (File.Exists(dest)) File.Delete(dest);
                File.Move(source, dest);
                Console.WriteLine($"Файл перемещен/переименован в: {dest}");
            }
        }

        public static void DeleteByPattern(string directory, string pattern)
        {
            string[] files = Directory.GetFiles(directory, pattern);
            foreach (var file in files)
            {
                File.Delete(file);
                Console.WriteLine($"Удален файл: {Path.GetFileName(file)}");
            }
        }

        public static void ListDirectoryFiles(string directory)
        {
            Console.WriteLine($"\nСписок файлов в {directory}:");
            foreach (var file in Directory.GetFiles(directory))
            {
                Console.WriteLine($" {Path.GetFileName(file)}");
            }
        }
    }
}

