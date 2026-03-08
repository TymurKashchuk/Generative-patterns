using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee => 200;
        public int MinPeriodMonths => 12;

        public List<string> Channels => new List<string>{
            "HBO", "Netflix", "Sports HD", "Movies HD", "4K Nature"
        };

        public List<string> Features => new List<string>{
            "4K якість", "4 пристрої", "Без реклами", "Офлайн перегляд"
        };
    }
}