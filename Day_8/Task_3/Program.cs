using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var storage = new SettingsStorage<string>();
            var manager = new SettingsManager<string>(storage);

            storage.Set("Theme", "Dark");
            storage.Set("Language", "Russian");
            storage.Set("FontSize", "14px");

            manager.ShowAllSettings();

            Console.WriteLine("\nПроверка ключа 'Theme': " + (storage.ContainsKey("Theme") ? "Есть" : "Нет"));

            manager.RemoveSetting("FontSize");
            manager.ShowAllSettings();

            Console.ReadKey();
        }
    }
}
