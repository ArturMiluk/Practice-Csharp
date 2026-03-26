using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class FileInfoProvider
    {
        public static void PrintFileInfo(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                Console.WriteLine($"\nИнформация о {fi.Name}:");
                Console.WriteLine($"Размер: {fi.Length} байт");
                Console.WriteLine($"Создан: {fi.CreationTime}");
                Console.WriteLine($"Изменен: {fi.LastWriteTime}");
            }
        }

        public static void CompareBySize(string path1, string path2)
        {
            FileInfo f1 = new FileInfo(path1);
            FileInfo f2 = new FileInfo(path2);
            if (f1.Exists && f2.Exists)
            {
                if (f1.Length == f2.Length) Console.WriteLine("Файлы равны по размеру.");
                else Console.WriteLine($"{(f1.Length > f2.Length ? f1.Name : f2.Name)} больше.");
            }
        }

        public static void CheckPermissions(string path)
        {
            FileInfo fi = new FileInfo(path);
            Console.WriteLine($"\nПрава доступа для {fi.Name}");
            Console.WriteLine($"Только чтение: {fi.IsReadOnly}");
            Console.WriteLine($"Может быть изменен: {!fi.IsReadOnly}");
        }
    }
}
