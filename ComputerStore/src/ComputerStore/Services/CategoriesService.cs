using ComputerStore.Interfaces;
using ComputerStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStore.Services
{
    public class CategoriesService : ICategoriesService
    {
        private IGenericRepository _repo;

        public CategoriesService(IGenericRepository repo)
        {
            _repo = repo;
        }

        //Get Category
        public List<Category> GetCategories()
        {
            List<Category> catList = (from c in _repo.Query<Category>()
                                         select new Category
                                         {
                                             Id = c.Id,
                                             Name = c.Name,
                                             Laptops = c.Laptops
                                         }).ToList();
            return catList;
        }

        public Category GetCategory(int id)
        {
            Category cat = (from c in _repo.Query<Category>()
                                 where c.Id == id
                                 select new Category
                                 {
                                     Id = c.Id,
                                     Name = c.Name,
                                     Laptops = c.Laptops
                                 }).FirstOrDefault();
            return cat;
        }

        /// <summary>
        /// Get Category without laptop for add, edit, and delete method
        /// </summary>
        public Category GetCategoryNoLaptop(int id)
        {
            Category catQuery = (from c in _repo.Query<Category>()
                                 where c.Id == id
                                 select c).FirstOrDefault();
            return catQuery;
        }

        public void AddCategory(Category cat)
        {
            _repo.Add(cat);
        }

        public void EditCategory(Category cat)
        {
            _repo.Update(cat);
        }

        public void DeleteCategory(int id)
        {
            Category catToDelete = GetCategory(id);
            _repo.Delete(catToDelete);
        }
    }
}
