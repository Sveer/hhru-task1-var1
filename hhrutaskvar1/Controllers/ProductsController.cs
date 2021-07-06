using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using hhrutaskvar1.Models;
using hhrutaskvar1.Data;

namespace hhrutaskvar1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return DataContext.Products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return DataContext.Products.FirstOrDefault(t => t.Id == id);
        }
    }
}
