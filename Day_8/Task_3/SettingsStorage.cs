using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class SettingsStorage<T> : ISettings<T>
    {
        private readonly Dictionary<string, T> _data = new Dictionary<string, T>();

        public void Set(string key, T value)
        {
            if (_data.ContainsKey(key))
                _data[key] = value;
            else
                _data.Add(key, value);
        }

        public T Get(string key)
        {
            if (_data.TryGetValue(key, out T value))
                return value;

            throw new KeyNotFoundException($"Настройка с ключом '{key}' не найдена.");
        }

        public bool ContainsKey(string key) => _data.ContainsKey(key);

        public IEnumerable<KeyValuePair<string, T>> GetAll() => _data;

        public bool Remove(string key) => _data.Remove(key);
    }
}
