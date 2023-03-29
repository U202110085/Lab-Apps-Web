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
        private List<Category> categories;
        public CategoryController()
        {
            categories = new List<Category>()
            {
                new Category(){id=1,Description = "nose", Quantity = 3},
                new Category(){id=2,Description = "nose", Quantity = 3},
                new Category(){id=3,Description = "nose", Quantity = 3},
                new Category(){id=4,Description = "nose", Quantity = 3}
            };
        }
        
        // GET: api/Category
        [HttpGet]
        public List<Tutorial> Get()
        {
            Category category = new Category()
            {
                id=1,name = "DIY", Quantity = 10,
                Tutorials = new List<Tutorial>()
                {
                    new Tutorial(){id = 1, title = "Sopa", Description = "Cosas de comida", Year = new DateTime(2023, 3, 28, 16, 30, 0)}
                }
            };
            return category.getTutorials();
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public Category Get(int id)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].id==id)
                {
                    return categories[i];
                }
            }
            
            return null;
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
