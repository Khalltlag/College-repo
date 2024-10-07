using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Linq;
namespace Pw_11
{
    // Обобщенный класс Repository
    public class Repository<T>
    {
        private List<T> items = new List<T>();
        // Добавление элемента
        public void Add(T item)
        {
            items.Add(item);
        }
        // Удаление элемента
        public void Remove(T item)
        {
            items.Remove(item);
        }

        // Получение всех элементов
        public List<T> GetAll()
        {
            return items;
        }
        // Поиск элемента по условию
        public T Find(Func<T, bool> predicate)
        {
            return items.FirstOrDefault(predicate);
        }
    }
}
