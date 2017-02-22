using System.Collections.Generic;
using ComputerStore.Models;

namespace ComputerStore.Interfaces
{
    public interface ILaptopsService
    {
        void AddLaptop(Laptop laptop);
        void DeleteLaptop(int id);
        void EditLaptop(Laptop laptop);
        Laptop GetLaptop(int id);
        List<Laptop> GetLaptops();
    }
}