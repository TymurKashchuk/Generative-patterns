using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class IPhoneNetbook : INetbook
    {
        public string Brand => "Apple";
        public string Model => "MacBook Air";
        public double Price => 64999;
    }
}
