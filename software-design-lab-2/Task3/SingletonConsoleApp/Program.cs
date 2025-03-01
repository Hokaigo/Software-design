using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authenticator auth1 = Authenticator.GetInstance();
            Authenticator auth2 = Authenticator.GetInstance();

            Console.WriteLine(ReferenceEquals(auth1, auth2));  

            auth1.Authenticate();
            auth2.Authenticate();
        }
    }
}
