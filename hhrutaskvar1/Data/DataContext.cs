using hhrutaskvar1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hhrutaskvar1.Data
{
    public class DataContext
    {
        public static List<Product> Products = new List<Product>();
        public static List<Order> Orders = new List<Order>();

        public static int NextOrderId = 1;

        // Инициализация списка продуктов
        static DataContext()
        {
            for (int i = 0; i < 100; i++)
            {
                var product = new Product
                {
                    Id = i + 1,
                    Name = $"Product #{(i + 1)}",
                    Price = 1000,
                    Quantity = 1000
                };

                Products.Add(product);
            }
        }
    }
}
