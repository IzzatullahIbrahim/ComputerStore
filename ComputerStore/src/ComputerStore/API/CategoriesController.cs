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
    public class CategoriesController : Controller
    {
        private ApplicationDbContext _db;

        public CategoriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Category> Get()
        {
            List<Category> categories = (from c in _db.Categories
                                         select new Category
                                         {
                                             Id = c.Id,
                                             Name = c.Name,
                                             Laptops = c.Laptops
                                         }).ToList();
            return categories;
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            Category category = (from c in _db.Categories
                                 where c.Id == id
                                 select new Category
                                 {
                                     Id = c.Id,
                                     Name = c.Name,
                                     Laptops = c.Laptops
                                 }).FirstOrDefault();
            return category;
        }
    }
}
