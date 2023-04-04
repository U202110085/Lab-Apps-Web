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
        private List<Category> _categories;
        public CategoryController()
        {
            _categories = new List<Category>()
            {
                new Category(){id=1,Description = "nose", Quantity = 3},
                new Category(){id=2,Description = "nose", Quantity = 3},
                new Category(){id=3,Description = "nose", Quantity = 3},
                new Category(){id=4,Description = "nose", Quantity = 3}
            };
        }
        
        // get tutorials by category
        // GET: api/Category/5
        [HttpGet("category/{id:int}")]
        public List<Tutorial> GetTutorials(int id)
        {
            Category category = _categories.FirstOrDefault( t => t.id == id);
            if (category != null)
            {
                return category.Tutorials;
            }
            return null;
        }
        
        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public Category GetById(int id)
        {
            // get tutorial by id
            for (int i = 0; i < _categories.Count; i++)
            {
                if (_categories[i].id==id)
                {
                    return _categories[i];
                }
            }
            
            return null;
        }

        // get all 
        // GET: api/Category
        [HttpGet ("all")]
        public List<Category> GetAll()
        {
            return _categories;
        }

        // add category
        // POST: api/Category
        [HttpPost("create")]
        public void Create([FromBody] Category category)
        {
            _categories.Add(category);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Category category = _categories.FirstOrDefault( t => t.id == id);
            if (category != null)
            {
                _categories.Remove(category);
                return Ok();
            }
            return NotFound();
        }
    }
}
