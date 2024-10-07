using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pw_11
{
    public class Order
    {
        public int OrderId { get; set; } // ID заказа

        private List<Product> Items;

        public decimal Price { get; set; }

        public Order(int orderId)
        {
            this.OrderId = orderId;
            this.Price = 0;
            Items = new List<Product>();
        }

        public override string ToString()
        {
            return $"ID заказа: {OrderId}, Заказы: {string.Join(", ", Items.Select(x => x.Name))}, Цена: {Price}";
        }

        // Добавление элемента
        public void Add(Product item)
        {
            Items.Add(item);
            Price = Price + item.Price;
        }
        // Удаление элемента
        public void Remove(Product item)
        {
            Items.Remove(item);
        }
        // Получение всех элементов
        public List<Product> GetAll()
        {
            return Items;
        }
        // Поиск элемента по условию


    }
}