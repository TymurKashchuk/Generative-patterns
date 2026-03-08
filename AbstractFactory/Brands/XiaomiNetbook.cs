using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class XiaomiNetbook : INetbook
    {
        public string Brand => "Xiaomi";
        public string Model => "Mi Notebook Air";
        public double Price => 21999;
    }
}
