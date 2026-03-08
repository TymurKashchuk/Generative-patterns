using FactoryMethod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    public abstract class SubscriptionCreator
    {
        public abstract ISubscription CreateSubscription(string type);
    }
}