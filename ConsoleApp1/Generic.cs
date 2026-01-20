using System;
using System.Collections.Generic;

namespace Program
{
    class GenericDataBase<T>
    {
        private List<T> items = new List<T>();

        public void CreateList(T item)
        {
            items.Add(item);
        }

        public void Display()
        {
            Console.WriteLine("List of items (" + typeof(T).Name + "):");

            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
