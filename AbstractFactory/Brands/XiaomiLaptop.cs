using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class XiaomiLaptop : ILaptop
    {
        public string Brand => "Xiaomi";
        public string Model => "Mi Notebook Pro";
        public double Price => 32999;
    }
}
