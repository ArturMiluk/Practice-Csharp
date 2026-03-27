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
            CacheManager cache1 = CacheManager.GetInstance();
            cache1.AddToCache("User_1", "Милюк Артур");

            CacheManager cache2 = CacheManager.GetInstance();
            cache2.AddToCache("Session_ID", 12345);

            if (ReferenceEquals(cache1, cache2))
            {
                Console.WriteLine("\nОба объекта ссылаются на один и тот же экземпляр.");
            }

            Console.WriteLine($"Данные из кэша: {cache2.GetFromCache("User_1")}");

            Console.ReadLine();
        }
    }
}