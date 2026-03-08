using FactoryMethod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    public class ManagerCall : SubscriptionCreator
    {
        public override ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Підписка створена через ManagerCall");
            switch (type.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "educational":
                    return new EducationalSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException($"Невідомий тип підписки: {type}");
            }
        }
    }
}