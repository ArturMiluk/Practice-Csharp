using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom globalChat = new ChatRoom();

            User user1 = new User("Админ");
            User user2 = new User("Владик");
            User user3 = new User("Миша");

            globalChat.RegisterUser(user1);
            globalChat.RegisterUser(user2);
            globalChat.RegisterUser(user3);

            globalChat.SendMessage("Миша", "Ну да.");
            globalChat.SendMessage("Владик", "Ну нет.");

            globalChat.UnregisterUser(user2);
            globalChat.SendMessage("Админ", "Владик покинул нас...");

            Console.ReadLine();
        }
    }
}
