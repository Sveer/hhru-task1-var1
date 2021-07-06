using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using hhrutaskvar1.Models;
using hhrutaskvar1.Data;

namespace hhrutaskvar1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return DataContext.Orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return DataContext.Orders.FirstOrDefault(t => t.Id == id);
        }

        // POST api/<OrdersController>
        // Добавление заказа
        [HttpPost]
        public string Post([FromBody] Order order)
        {
            // Запрашиваем из "БД" требуемый продукт
            var neededProduct = DataContext.Products.FirstOrDefault(t => t.Id == order.ProductId);

            if (neededProduct == null)
                return $"Ошибка: Запрашиваемый продукт не найден";

            // Есть ли на складе необходимое кол-во?
            if (neededProduct.Quantity < order.ProductsCount)
                return "Ошибка: На складе нет необходимого количества продуктов";

            neededProduct.Quantity -= order.ProductsCount;
            order.Id = DataContext.NextOrderId++;

            DataContext.Orders.Add(order);

            return $"Заказ успешно зарегистрирован. Ваш номер заказа: {order.Id}";
        }
    }
}
