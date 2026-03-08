using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public decimal MonthlyFee => 140;
        public int MinPeriodMonths => 6;

        public List<string> Channels => new List<string>{
            "Discovery","National Geographic", "History", "EnglishDom"
        };

        public List<string> Features => new List<string>{
            "Доступ до записів","HD якість","Освітній контент", "2 пристрої"
        };
    }
}