using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public decimal MonthlyFee => 120;
        public int MinPeriodMonths => 3;

        public List<string> Channels => new List<string> {
            "1+1", "СТБ", "ICTV"
        };

        public List<string> Features => new List<string>{
            "HD якість", "1 пристрій"
        };
    }
}