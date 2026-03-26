using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string surname = "miluk";
            string initials = "aa";
            string fileName = $"{surname}.{initials}";
            string renamedName = $"{surname}.io";

            FileManager.CreateAndWrite(fileName, "Hello, World!");
            FileManager.ReadAndPrint(fileName);

            FileInfoProvider.PrintFileInfo(fileName);

            string copyName = "copy_" + fileName;
            FileManager.Copy(fileName, copyName);

            FileInfoProvider.CompareBySize(fileName, copyName);

            FileInfo fi = new FileInfo(fileName);
            fi.IsReadOnly = true;
            Console.WriteLine("Атрибут 'Только чтение' включен.");
            try { File.AppendAllText(fileName, "New line"); }
            catch (Exception e) { Console.WriteLine($"{e.Message}"); }
            fi.IsReadOnly = false;

            string dirName = "Test";
            if (!Directory.Exists(dirName)) Directory.CreateDirectory(dirName);
            FileManager.MoveOrRename(copyName, Path.Combine(dirName, copyName));

            FileManager.MoveOrRename(fileName, renamedName);

            FileManager.ListDirectoryFiles(Directory.GetCurrentDirectory());

            FileManager.DeleteByPattern(Directory.GetCurrentDirectory(), $"*.{initials}");

            FileManager.SafeDelete(renamedName);

            Console.ReadLine();
        }
    }
}
