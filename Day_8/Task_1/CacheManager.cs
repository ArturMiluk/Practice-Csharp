using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class CacheManager
    {
        private readonly Hashtable _cache = new Hashtable();

        public void AddToCache(string key, CacheItem item)
        {
            if (!_cache.ContainsKey(key))
            {
                _cache.Add(key, item);
                Console.WriteLine($"Запись с ключом '{key}' добавлена в кэш.");
            }
            else
            {
                Console.WriteLine($"Ключ '{key}' уже существует.");
            }
        }

        public CacheItem GetFromCache(string key)
        {
            if (_cache.ContainsKey(key))
            {
                return (CacheItem)_cache[key];
            }
            return null;
        }

        public void RemoveFromCache(string key)
        {
            if (_cache.ContainsKey(key))
            {
                _cache.Remove(key);
                Console.WriteLine($"Запись '{key}' удалена.");
            }
        }

        public void ShowAllCache()
        {
            foreach (DictionaryEntry entry in _cache)
            {
                Console.WriteLine($"Ключ: {entry.Key} | Значение: {entry.Value}");
            }
        }
    }
}

