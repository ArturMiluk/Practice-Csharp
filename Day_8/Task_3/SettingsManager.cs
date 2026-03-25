using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class SettingsManager<T>
    {
        private readonly SettingsStorage<T> _storage;

        public SettingsManager(SettingsStorage<T> storage)
        {
            _storage = storage;
        }

        public void ShowAllSettings()
        {
            Console.WriteLine($"Настройки: ({typeof(T).Name})");
            foreach (var item in _storage.GetAll())
            {
                Console.WriteLine($"Ключ: {item.Key,-15} | Значение: {item.Value}");
            }
        }

        public void RemoveSetting(string key)
        {
            if (_storage.Remove(key))
                Console.WriteLine($"Настройки: '{key}' успешно удалена.");
            else
                Console.WriteLine($"Ошибка: Настройка '{key}' не существует.");
        }
    }
}

