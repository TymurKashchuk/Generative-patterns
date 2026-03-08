using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Devices
{
    public interface IEBook
    {
        string Brand { get; }
        string Model { get; }
        double Price { get; }

        void PrintInfo()
        {
            Console.WriteLine($"EBook {Brand} {Model} — {Price} грн");
        }
    }
}
