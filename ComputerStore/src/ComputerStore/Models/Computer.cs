using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public abstract class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Processor { get; set; }
        public string Motherboard { get; set; }
        public string Memory { get; set; }
        public string GPU { get; set; }
        public string OperatingSystem { get; set; }
        public string IOInput1 { get; set; }
        public string IOInput2 { get; set; }
        public string IOInput3 { get; set; }
        public string IOInput4 { get; set; }
        public string IOInput5 { get; set; }
        public string IOInput6 { get; set; }
        public string IOInput7 { get; set; }
        public string IOInput8 { get; set; }
        public string Storage1 { get; set; }
        public string Storage2 { get; set; }
        public string Storage3 { get; set; }
        public string Storage4 { get; set; }
        public string Ethernet { get; set; }
        public string Wireless { get; set; }
        public string Bluetooth { get; set; }
        public int Quantity { get; set; }
        public string GalleryProcessor { get; set; }
        public string GalleryDisplay { get; set; }
        public string GalleryGPU { get; set; }
        public string GalleryMemory { get; set; }
        public string GalleryStorage { get; set; }
    }
}
