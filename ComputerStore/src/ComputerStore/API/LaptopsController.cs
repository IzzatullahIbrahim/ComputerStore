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
                                        GalleryWireless = l.GalleryWireless,
                                        GalleryOS = l.GalleryOS
                                    }).ToList();
            return laptops;
        }

        [HttpGet("{id}")]
        public Laptop Get(int id)
        {
            Laptop laptop = (from l in _db.Laptops
                             where l.Id == id
                             select new Laptop
                             {
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
                                 GalleryWireless = l.GalleryWireless,
                                 GalleryOS = l.GalleryOS
                             }).FirstOrDefault();
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
                _db.Laptops.Add(laptop);
                _db.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
