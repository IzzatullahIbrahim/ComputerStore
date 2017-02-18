using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerStore.Data;
using ComputerStore.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ComputerStore.API
{
    [Route("api/[controller]")]
    public class LaptopsController : Controller
    {
        private ApplicationDbContext _db;

        public LaptopsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Laptop> Get()
        {
            List<Laptop> laptops = (from l in _db.Laptops
                                    select new Laptop
                                    {
                                        ImageUrl = l.ImageUrl,
                                    }).ToList();
            return laptops;
        }
    }
}
