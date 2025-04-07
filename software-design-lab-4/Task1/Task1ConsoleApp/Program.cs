using System;
using Task1ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Handler callOperatorHandler = new CallOperatorHandler();
        Handler changeTariffHandler = new ChangeTariffHandler();
        Handler checkBalanceHandler = new CheckBalanceHandler(); 
        Handler specialOffersHandler = new SpecialOffersHandler(); 

        callOperatorHandler.SetNextHandler(changeTariffHandler).SetNextHandler(checkBalanceHandler).SetNextHandler(specialOffersHandler);

        int checker = 0;
        while (true)
        {
            if (checker == 1)
                Console.WriteLine();
            Console.WriteLine("Please select the type of support you need:");
            Console.WriteLine("1 - Call Operator");
            Console.WriteLine("2 - Change Tariff");
            Console.WriteLine("3 - Balance Check");
            Console.WriteLine("4 - Special Offers");
            Console.WriteLine("0 - Exit");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int requestNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (requestNumber == 0)
            {
                Console.WriteLine("Exiting the system...");
                break;
            }

            if (requestNumber < 1 || requestNumber > 4)
            {
                Console.WriteLine("Please select a valid option.");
                continue;
            }

            SupportedRequestType request = (SupportedRequestType)requestNumber;

            bool handled = callOperatorHandler.Handle(request);

            if (!handled)
            {
                Console.WriteLine("An error here is not vaild handler, please connect to administrator");
            }
            else
            {
                Console.WriteLine("\nWish you continue? (yes/no)");
                if (checker == 0)
                    checker = 1;
                string answer = Console.ReadLine().ToLower();
                if (answer != "yes")
                {
                    Console.WriteLine("Exiting the system...");
                    break;
                }
            }
        }
    }
}
