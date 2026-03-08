using FactoryMethod.Creators;
using FactoryMethod.Subscriptions;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SubscriptionCreator webSite = new WebSite();
            SubscriptionCreator mobileApp = new MobileApp();
            SubscriptionCreator managerCall = new ManagerCall();

            Console.WriteLine("WebSite:");
            ISubscription sub1 = webSite.CreateSubscription("domestic");
            sub1.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("MobileApp:");
            ISubscription sub2 = mobileApp.CreateSubscription("educational");
            sub2.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("ManagerCall: ");
            ISubscription sub3 = managerCall.CreateSubscription("premium");
            sub3.PrintInfo();
        }
    }
}