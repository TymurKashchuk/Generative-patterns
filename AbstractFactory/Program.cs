using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            IDeviceFactory appleFactory = new IPhoneFactory();
            IDeviceFactory xiaomiFactory = new XiaomiFactory();
            Console.WriteLine("Apple:");
            appleFactory.CreateLaptop().PrintInfo();
            appleFactory.CreateNetbook().PrintInfo();
            appleFactory.CreateEBook().PrintInfo();
            appleFactory.CreateSmartphone().PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Xiaomi:");
            xiaomiFactory.CreateLaptop().PrintInfo();
            xiaomiFactory.CreateNetbook().PrintInfo();
            xiaomiFactory.CreateEBook().PrintInfo();
            xiaomiFactory.CreateSmartphone().PrintInfo();
        }
    }
}
