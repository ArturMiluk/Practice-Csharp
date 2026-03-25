using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public interface ISettings<T>
    {
        void Set(string key, T value);
        T Get(string key);
        bool ContainsKey(string key);
    }
}

