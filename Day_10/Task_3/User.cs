using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class User : IChatUser
    {
        public string Name {get; private set;}

        public User(string name)
        {
            Name = name;
        }

        public void Update(string sender, string message)
        {
            if (sender != Name)
            {
                Console.WriteLine($"Уведомление для {Name}: {sender} пишет: '{message}'");
            }
        }
    }
}

