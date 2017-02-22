using System.Collections.Generic;
using ComputerStore.Models;

namespace ComputerStore.Interfaces
{
    public interface ICategoriesService
    {
        void AddCategory(Category cat);
        void DeleteCategory(int id);
        void EditCategory(Category cat);
        List<Category> GetCategories();
        Category GetCategory(int id);
        Category GetCategoryNoLaptop(int id);
    }
}