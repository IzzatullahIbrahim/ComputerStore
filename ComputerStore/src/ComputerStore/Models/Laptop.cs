using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class Laptop : Computer
    {
        public string Display { get; set; }
        public string Audio { get; set; }
        public string Security1 { get; set; }
        public string Security2 { get; set; }
        public string Battery { get; set; }
        public string Adapter { get; set; }
        public string Dimension { get; set; }
        public string Weight { get; set; }
    }
}
