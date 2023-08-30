using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_Project_Api.DAL.ApiContext;
using AspNetCore_Project_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var c = new Context();
            return Ok(c.Categories.ToList());
        }
        
        [HttpGet("{id}")]
        public IActionResult CategoryDetail(int id)
        {
            var c = new Context();
            var category = c.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            var c = new Context();
            c.Categories.Add(category);
            c.SaveChanges();
            return Created("",category);
        }
        
        [HttpDelete("{id}")]
        public IActionResult CategoryDelete(int id)
        {
            var c = new Context();
            var category = c.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            c.Categories.Remove(category);
            c.SaveChanges();
            return Ok(category);
        }
        
        [HttpPut("{id}")]
        public IActionResult CategoryUpdate(int id,Category category)
        {
            var c = new Context();
            var cat = c.Categories.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            cat.Name = category.Name;
            c.SaveChanges();
            return Ok(cat);
        }
    }
}
