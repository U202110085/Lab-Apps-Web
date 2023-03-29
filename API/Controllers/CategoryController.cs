using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/Category
        [HttpGet]
        public List<Tutorial> Get()
        {
            Category category = new Category();
            return category.getTutorials();
        }
        

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public Category Get(int Id)
        {
            Category category = new Category() {id = 1, name = "DIY", Description = "Realizar cosas por tu propia cuenta", Quantity= 23 };
            if (category.id == Id)
            {
                //StatusCode(500);
                return category;
            }
            else
            {
                //StatusCode(201);
                return null;
            }
        }

        // POST: api/Category
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public void Delete1(int id)
        {
        }
    }
}
