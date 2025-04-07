using System;
using System.Threading;

namespace Task1ClassLibrary
{
    public class CheckBalanceHandler : Handler
    {
        private decimal balance = 100.00m;
        public override bool Handle(SupportedRequestType request)
        {
           if (request == SupportedRequestType.CheckBalance)
           {
                Console.Write("Getting your current balance");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"\nYour balance is {balance:F2}.");
                return true;
           }
           return HandleNext(request);
        }
    }
}
