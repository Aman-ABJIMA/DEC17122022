using Storage_App.NewFolder;
using System;
namespace Storage_App.repositories
{
    internal class GenericRepository<T>
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach(var item in _items)
            {
                Console.WriteLine(item);
            }
        }


    }
}
