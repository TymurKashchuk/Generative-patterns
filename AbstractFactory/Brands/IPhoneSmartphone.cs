using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class IPhoneSmartphone : ISmartphone
    {
        public string Brand => "Apple";
        public string Model => "iPhone 15 Pro";
        public double Price => 54999;
    }
}
