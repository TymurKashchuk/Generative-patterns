using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Authenticator
    {
        private static Authenticator _instance;
        private static readonly object _lock = new object();

        private Authenticator() {
            Console.WriteLine("Authenticator created");
        }

        public static Authenticator GetInstance() {
            if (_instance == null) {
                lock (_lock) {
                    if (_instance == null) {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }

        public void Authenticate(string user) {
            Console.WriteLine($"User {user} logged in");
        }
    }
}
