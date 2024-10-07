using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_11
{
    class PublicRep<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public IEnumerable<T> GetAllOrders()
        {
            return _items;
        }
    }
}
