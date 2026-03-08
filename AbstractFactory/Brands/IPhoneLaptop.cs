using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class IPhoneLaptop : ILaptop
    {
        public string Brand => "Apple";
        public string Model => "MacBook Pro";
        public double Price => 89999;
    }
}
