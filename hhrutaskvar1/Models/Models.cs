using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hhrutaskvar1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Количество на складе
        /// </summary>
        public int Quantity { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductsCount { get; set; }
    }
}
