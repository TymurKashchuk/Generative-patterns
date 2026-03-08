using AbstractFactory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Brands
{
    public class XiaomiEBook : IEBook
    {
        public string Brand => "Xiaomi";
        public string Model => "Mi EBook Reader";
        public double Price => 8999;
    }
}
