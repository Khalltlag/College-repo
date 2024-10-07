using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
namespace Pw_11
{
    // Класс Product
   public class Product
   {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }
    public decimal SumPrice { get; set; }
    public Product(int id, string name, decimal price, string category, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
        Stock = stock;
        SumPrice = Stock * Price;
    }

        public override string ToString()
      {
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Category: {Category}, Stock: {Stock}, All price: {SumPrice}";
      }
    }
}
