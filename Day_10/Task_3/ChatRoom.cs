using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ChatRoom
    {
        private List<IChatUser> _users = new List<IChatUser>();

        public void RegisterUser(IChatUser user)
        {
            _users.Add(user);
            Console.WriteLine($"{user.Name} присоединился к чату.");
        }

        public void UnregisterUser(IChatUser user)
        {
            _users.Remove(user);
            Console.WriteLine($"{user.Name} покинул чат.");
        }

        public void SendMessage(string sender, string message)
        {
            Console.WriteLine($"\nНовое сообщение от {sender}: {message}");
            foreach (var user in _users)
            {
                user.Update(sender, message);
            }
        }
    }
}

