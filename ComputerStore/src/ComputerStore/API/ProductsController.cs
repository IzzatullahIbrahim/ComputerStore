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
    public class ProductsController : Controller
    {
        private ApplicationDbContext _db;

        public ProductsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Laptop> Get()
        {
            List<Laptop> products = (from p in _db.Laptops
                                     select new Laptop {
                                         Id = p.Id,
                                         Brand = p.Brand
                                     }).ToList();
            return products;
        }
    }
}
