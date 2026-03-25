using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class MyQueue<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Enqueue(T item)
        {
            _items.Add(item);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Очередь пуста.");

            T item = _items[0];
            _items.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Очередь пуста.");

            return _items[0];
        }

        public int Count() => _items.Count;

        public bool IsEmpty() => _items.Count == 0;
    }
}

