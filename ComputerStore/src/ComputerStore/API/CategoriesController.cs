using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerStore.Data;
using ComputerStore.Models;
using ComputerStore.Interfaces;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ComputerStore.API
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private ICategoriesService _catService;

        public CategoriesController(ICategoriesService catService)
        {
            _catService = catService;
        }

        [HttpGet]
        public List<Category> Get()
        {
            List<Category> categories = _catService.GetCategories();
            return categories;
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            Category category = _catService.GetCategory(id);
            return category;
        }

        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        public IActionResult Post([FromBody]Category cat)
        {
            if (cat == null)
            {
                return BadRequest();
            }
            else if (cat.Id == 0)
            {
                _catService.AddCategory(cat);
                return Ok();
            }
            else
            {
                _catService.EditCategory(cat);
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        public IActionResult Delete(int id)
        {
            _catService.DeleteCategory(id);
            return Ok();
        }
    }
}
