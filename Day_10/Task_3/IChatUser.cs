using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public interface IChatUser
    {
        void Update(string sender, string message);
        string Name {get;}
    }
}

