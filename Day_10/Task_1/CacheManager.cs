using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 {
    public class CacheManager
    {
        private static CacheManager _instance;

        private Dictionary<string, object> _cache;

        private CacheManager()
        {
            _cache = new Dictionary<string, object>();
            Console.WriteLine("CacheManager инициализирован.");
        }

        public static CacheManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CacheManager();
            }
            return _instance;
        }

        public void AddToCache(string key, object value)
        {
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;
            }
            else
            {
                _cache.Add(key, value);
            }
            Console.WriteLine($"Добавлено: {key}");
        }

        public object GetFromCache(string key)
        {
            if (_cache.ContainsKey(key))
            {
                return _cache[key];
            }
            Console.WriteLine($"Ключ '{key}' не найден.");
            return null;
        }
    }
}
