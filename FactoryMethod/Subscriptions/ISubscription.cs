using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinPeriodMonths { get; }
        List<string> Channels { get; }
        List<string> Features { get; }

        void PrintInfo()
        {
            Console.WriteLine($"Місячна плата: {MonthlyFee} грн");
            Console.WriteLine($"Мінімальний період: {MinPeriodMonths} міс.");
            Console.WriteLine($"Канали: {string.Join(", ", Channels)}");
            Console.WriteLine($"Можливості: {string.Join(", ", Features)}");
        }
    }
}