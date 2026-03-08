using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class XiaomiSmartphone : ISmartphone
    {
        public string Brand => "Xiaomi";
        public string Model => "Redmi Note 13 Pro";
        public double Price => 12999;
    }
}
