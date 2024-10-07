using Pw_11;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Pw_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта репозитория для товаров
            var productRepository = new Repository<Product>();

            // Добавление товаров
            productRepository.Add(new Product(1, "Laptop", 1200, "Electronics", 0));
            productRepository.Add(new Product(2, "Smartphone", 800, "Electronics", 53));
            productRepository.Add(new Product(3, "Chair", 150, "Furniture", 16));
            productRepository.Add(new Product(4, "Table", 300, "Furniture", 48));
            productRepository.Add(new Product(5, "TV", 1000, "Electronics", 98));

            //заказ

            var order = new Order(0);

            order.Add(productRepository.Find(x => x.Id.Equals(1)));
            order.Add(productRepository.Find(x => x.Id.Equals(2)));

            Console.WriteLine(order.ToString());

            // LINQ-запрос: найти все товары в категории "Electronics"
            var electronics = productRepository.GetAll()
            .Where(p => p.Category == "Electronics");
            Console.WriteLine("Товары в категории 'Electronics':");
            foreach (var product in electronics)
            {
                Console.WriteLine(product);
            }


            // LINQ-запрос: найти самый дорогой товар
            var mostExpensive = productRepository.GetAll()
            .OrderByDescending(p => p.Price)
            .FirstOrDefault();
            Console.WriteLine($"\nСамый дорогой товар: {mostExpensive}");


            // LINQ-запрос: отсортировать товары по цене
            var sortedByPrice = productRepository.GetAll()
            .OrderBy(p => p.Price);

            Console.WriteLine("\nТовары, отсортированные по цене:");
            foreach (var product in sortedByPrice)
            {
                Console.WriteLine(product);
            }

            // LINQ-запрос: посчитать общее количество товаров
            var totalProducts = productRepository.GetAll().Count();
            Console.WriteLine($"\nОбщее количество товаров: {totalProducts}");

            // LINQ-запрос: всех товаров на складе
            var sortedByAmount = productRepository.GetAll()
                .Where(p => p.Stock > 0)
                .OrderBy(p => p.Stock);

            foreach (var product in sortedByAmount)
            {
                Console.WriteLine($"Общее количество товаров на складе: {product}");
            }

            Console.WriteLine("На складе {0} he,ktq njdfhjd", productRepository.GetAll()
                .Where(p => p.Stock > 0)
                .Sum(p => p.SumPrice));

        }
    }
}
