using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            CacheManager manager = new CacheManager();

            manager.AddToCache("user_1", new CacheItem("Милюк Артур"));
            manager.AddToCache("session_token", new CacheItem("id-3"));

            var item = manager.GetFromCache("user_1");
            if (item != null)
                Console.WriteLine($"\nИнформация из кэша: {item.Data}");

            manager.ShowAllCache();

            manager.RemoveFromCache("session_token");

            Console.ReadKey();
        }
    }
}
