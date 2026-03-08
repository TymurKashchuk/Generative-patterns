using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class IPhoneEBook : IEBook
    {
        public string Brand => "Apple";
        public string Model => "iPad mini";
        public double Price => 24999;
    }
}
