using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsoleApp
{
    public class Authenticator
    {
        private static Authenticator _instance;
        private static readonly object _lock = new object();

        private Authenticator() { }

        public static Authenticator GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new Authenticator();
                return _instance;
            }
        }

        public void Authenticate() => Console.WriteLine("Authenticated!");
    }
}
