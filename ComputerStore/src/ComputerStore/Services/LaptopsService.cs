using ComputerStore.Interfaces;
using ComputerStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStore.Services
{
    public class LaptopsService: ILaptopsService
    {
        private IGenericRepository _repo;
        private ICategoriesService _cService;

        public LaptopsService(IGenericRepository repo, ICategoriesService cService)
        {
            _repo = repo;
            _cService = cService;
        }

        public List<Laptop> GetLaptops()
        {
            List<Laptop> lapList = (from l in _repo.Query<Laptop>()
                                    select new Laptop
                                    {
                                        Category = l.Category,
                                        Id = l.Id,
                                        Brand = l.Brand,
                                        Model = l.Model,
                                        Price = l.Price,
                                        ImageUrl = l.ImageUrl,
                                        Processor = l.Processor,
                                        Motherboard = l.Motherboard,
                                        Memory = l.Memory,
                                        GPU = l.GPU,
                                        OperatingSystem = l.OperatingSystem,
                                        IOInput1 = l.IOInput1,
                                        IOInput2 = l.IOInput2,
                                        IOInput3 = l.IOInput3,
                                        IOInput4 = l.IOInput4,
                                        IOInput5 = l.IOInput5,
                                        IOInput6 = l.IOInput6,
                                        IOInput7 = l.IOInput7,
                                        IOInput8 = l.IOInput8,
                                        Storage1 = l.Storage1,
                                        Storage2 = l.Storage2,
                                        Storage3 = l.Storage3,
                                        Storage4 = l.Storage4,
                                        Ethernet = l.Ethernet,
                                        Wireless = l.Wireless,
                                        Bluetooth = l.Bluetooth,
                                        Display = l.Display,
                                        Audio = l.Audio,
                                        Security1 = l.Security1,
                                        Security2 = l.Security2,
                                        Battery = l.Battery,
                                        Adapter = l.Adapter,
                                        Dimension = l.Dimension,
                                        Weight = l.Weight,
                                        Quantity = l.Quantity,
                                        GalleryProcessor = l.Processor,
                                        GalleryDisplay = l.GalleryDisplay,
                                        GalleryGPU = l.GalleryGPU,
                                        GalleryMemory = l.GalleryMemory,
                                        GalleryStorage = l.GalleryStorage,
                                        GalleryBatteryDimension = l.GalleryBatteryDimension
                                    }).ToList();
            return lapList;
        }

        public Laptop GetLaptop(int id)
        {
            Laptop lap = (from l in _repo.Query<Laptop>()
                             where l.Id == id
                             select new Laptop
                             {
                                 Category = l.Category,
                                 Id = l.Id,
                                 Brand = l.Brand,
                                 Model = l.Model,
                                 Price = l.Price,
                                 ImageUrl = l.ImageUrl,
                                 Processor = l.Processor,
                                 Motherboard = l.Motherboard,
                                 Memory = l.Memory,
                                 GPU = l.GPU,
                                 OperatingSystem = l.OperatingSystem,
                                 IOInput1 = l.IOInput1,
                                 IOInput2 = l.IOInput2,
                                 IOInput3 = l.IOInput3,
                                 IOInput4 = l.IOInput4,
                                 IOInput5 = l.IOInput5,
                                 IOInput6 = l.IOInput6,
                                 IOInput7 = l.IOInput7,
                                 IOInput8 = l.IOInput8,
                                 Storage1 = l.Storage1,
                                 Storage2 = l.Storage2,
                                 Storage3 = l.Storage3,
                                 Storage4 = l.Storage4,
                                 Ethernet = l.Ethernet,
                                 Wireless = l.Wireless,
                                 Bluetooth = l.Bluetooth,
                                 Display = l.Display,
                                 Audio = l.Audio,
                                 Security1 = l.Security1,
                                 Security2 = l.Security2,
                                 Battery = l.Battery,
                                 Adapter = l.Adapter,
                                 Dimension = l.Dimension,
                                 Weight = l.Weight,
                                 Quantity = l.Quantity,
                                 GalleryProcessor = l.Processor,
                                 GalleryDisplay = l.GalleryDisplay,
                                 GalleryGPU = l.GalleryGPU,
                                 GalleryMemory = l.GalleryMemory,
                                 GalleryStorage = l.GalleryStorage,
                                 GalleryBatteryDimension = l.GalleryBatteryDimension
                             }).FirstOrDefault();
            return lap;
        }

        public void AddLaptop(Laptop laptop)
        {
            Category cat = _cService.GetCategoryNoLaptop(laptop.Category.Id);
            laptop.Category = cat;

            _repo.Add(laptop);
        }

        public void EditLaptop(Laptop laptop)
        {
            Category cat = _cService.GetCategoryNoLaptop(laptop.Category.Id);
            laptop.Category = cat;

            _repo.Update(laptop);
        }

        public void DeleteLaptop(int id)
        {
            Laptop lapToDelete = GetLaptop(id);
            _repo.Delete(lapToDelete);
        }
    }
}
