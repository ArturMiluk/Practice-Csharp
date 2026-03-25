using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class CacheItem
    {
        public string Data {get; set;}
        public DateTime CreatedAt {get;}

        public CacheItem(string data)
        {
            Data = data;
            CreatedAt = DateTime.Now;
        }

        public override string ToString() => $"Данные: {Data}, Создано: {CreatedAt:HH:mm:ss}";
    }
}

