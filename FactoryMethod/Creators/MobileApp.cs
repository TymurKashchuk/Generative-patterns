using FactoryMethod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    public class MobileApp : SubscriptionCreator
    {
        public override ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Підписка створена через MobileApp");
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