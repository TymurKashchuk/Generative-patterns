namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Authenticator auth1 = Authenticator.GetInstance();
            Authenticator auth2 = Authenticator.GetInstance();
            Authenticator auth3 = Authenticator.GetInstance();
            Console.WriteLine($"auth1 == auth2: {ReferenceEquals(auth1, auth2)}");
            Console.WriteLine($"auth2 == auth3: {ReferenceEquals(auth2, auth3)}");
            auth1.Authenticate("admin");
            auth2.Authenticate("user");

            //перевірка багатопотоковості
            for (int i = 1; i <= 5; i++)
            {
                new Thread(() => {
                    Authenticator auth = Authenticator.GetInstance();
                    Console.WriteLine($"Потік {i}: hashCode = {auth.GetHashCode()}");
                }).Start();
            }
        }
    }
}
