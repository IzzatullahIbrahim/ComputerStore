using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerStore.Data;
using ComputerStore.Models;
using ComputerStore.Interfaces;

//For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ComputerStore.API
{
    [Route("api/[controller]")]
    public class LaptopsController : Controller
    {
        private ILaptopsService _lapService;
        private ICategoriesService _catService;

        public LaptopsController(ILaptopsService lapService, ICategoriesService catService)
        {
            _lapService = lapService;
            _catService = catService;
        }

        [HttpGet]
        public List<Laptop> Get()
        {
            List<Laptop> laptops = _lapService.GetLaptops();
            return laptops;
        }

        [HttpGet("{id}")]
        public Laptop Get(int id)
        {
            Laptop laptop = _lapService.GetLaptop(id);
            return laptop;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Laptop laptop)
        {
            if (laptop == null)
            {
                return BadRequest();
            }
            else if (laptop.Id == 0)
            {
                _lapService.AddLaptop(laptop);
                return Ok();
            }
            else
            {
                _lapService.EditLaptop(laptop);
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _lapService.DeleteLaptop(id);
            return Ok();
        }
    }
}
