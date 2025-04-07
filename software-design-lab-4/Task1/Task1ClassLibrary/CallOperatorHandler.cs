using System;
using System.Threading;

namespace Task1ClassLibrary
{
    public class CallOperatorHandler : Handler
    {
        public override bool Handle(SupportedRequestType request)
        {
            if (request == SupportedRequestType.CallOperator)
            {
                Console.Write("Connecting to an operator");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("\nYou are now connected to the operator.");
                return true;
            }

            return HandleNext(request);
        }
    }
}
