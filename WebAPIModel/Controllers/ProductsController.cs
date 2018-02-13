using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIModel.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private static List<string> products = new List<string>();

        // GET: api/Products
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return products.ToArray();
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return products.ElementAt(id);
        }
        
        // POST: api/Products
        [HttpPost]
        public void Post([FromBody]string value)
        {
            products.Add(value);
        }
        
        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            products[id] = value;
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            products.RemoveAt(id);
        }
    }

}
