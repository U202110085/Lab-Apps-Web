using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {

        private readonly List<Tutorial> _tutorials;

        public TutorialController()
        {
            _tutorials = new List<Tutorial>
                     {
                         new Tutorial() { id = 1, title = "Tutorial 1", Description = "Description 1" },
                         new Tutorial() { id = 2, title = "Tutorial 2", Description = "Description 2" },
                         new Tutorial() { id = 3, title = "Tutorial 3", Description = "Description 3" },
                         new Tutorial() { id = 4, title = "Tutorial 4", Description = "Description 4" },
                         new Tutorial() { id = 5, title = "Tutorial 5", Description = "Description 5" },
                         new Tutorial() { id = 6, title = "Tutorial 6", Description = "Description 6" },
                         new Tutorial() { id = 7, title = "Tutorial 7", Description = "Description 7" },
                         new Tutorial() { id = 8, title = "Tutorial 8", Description = "Description 8" },
                         new Tutorial() { id = 9, title = "Tutorial 9", Description = "Description 9" },
                         new Tutorial() { id = 10,title = "Tutorial 10", Description = "Description 10" },
                     };
        }
        // get all tuturials
        [HttpGet("all")]
        public List<Tutorial> GetAll()
        {
            return _tutorials;
        }
        
        // GET: api/Tutorial/5
        // get tuturial by id
        [HttpGet("{id}")]
        public Tutorial GetById(int id)
        {
            return _tutorials.FirstOrDefault(t => t.id == id);
        }
        
        
        // create tuturial
        [HttpPost("create")]
        public void Create([FromBody] Tutorial tutorial)
        {
            _tutorials.Add(tutorial);
        }
        
        // update tuturial by id
        [HttpPut("update/{id}")]
        public void Update(int id, [FromBody] Tutorial tutorial)
        {
            Tutorial newTutorial = _tutorials.FirstOrDefault(e => e.id == id);
            if (newTutorial != null)
            {
                newTutorial.title = tutorial.title;
                newTutorial.Description = tutorial.Description;
            }
        }
        
        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Tutorial tutorial = _tutorials.FirstOrDefault(t => t.id == id);
            if (tutorial == null)
            {
                return NotFound();
            }
            Console.WriteLine(_tutorials.Remove(tutorial));
            return Ok();
        }
    }
}
