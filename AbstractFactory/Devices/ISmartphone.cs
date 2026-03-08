using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Devices
{
    public interface ISmartphone
    {
        string Brand { get; }
        string Model { get; }
        double Price { get; }

        void PrintInfo()
        {
            Console.WriteLine($"Smartphone {Brand} {Model} — {Price} грн");
        }
    }
}
