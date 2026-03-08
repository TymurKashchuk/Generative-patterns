using AbstractFactory.Devices;
using AbstractFactory.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class XiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new XiaomiLaptop();
        public INetbook CreateNetbook() => new XiaomiNetbook();
        public IEBook CreateEBook() => new XiaomiEBook();
        public ISmartphone CreateSmartphone() => new XiaomiSmartphone();
    }
}
