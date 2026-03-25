using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class QueueProcessor<T>
    {
        private readonly MyQueue<T> _queue = new MyQueue<T>();

        public void AddTask(T task)
        {
            Console.WriteLine($"Добавлена задача: {task}");
            _queue.Enqueue(task);
        }

        public void ProcessAll()
        {
            Console.WriteLine("\nНачало обработки задач.");
            while (!_queue.IsEmpty())
            {
                T currentTask = _queue.Dequeue();
                Console.WriteLine($"Выполняется: {currentTask}. Осталось: {_queue.Count()}");
            }
            Console.WriteLine("Все задачи выполнены.");
        }
    }
}

