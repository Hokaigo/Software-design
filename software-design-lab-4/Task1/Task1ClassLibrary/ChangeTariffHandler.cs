using System;
using System.Threading;

namespace Task1ClassLibrary
{
    public class ChangeTariffHandler : Handler
    {
        private int currentTariff = 1;

        public override bool Handle(SupportedRequestType request)
        {
            if (request == SupportedRequestType.ChangeTariff)
            {
                while (true)
                {
                    Console.WriteLine($"\nCurrent tariff: {GetTariffName(currentTariff)}");
                    Console.WriteLine("Please select a new tariff:");
                    Console.WriteLine("1 - Base tariff");
                    Console.WriteLine("2 - Standard tariff");
                    Console.WriteLine("3 - Premium tariff");
                    Console.WriteLine("0 - Go back");

                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int selectedTariff))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    if (selectedTariff == 0)
                    {
                        Console.WriteLine("Returning to previous menu.");
                        return false;
                    }

                    if (selectedTariff < 1 || selectedTariff > 3)
                    {
                        Console.WriteLine("Please select a valid tariff option.");
                        continue;
                    }

                    if (selectedTariff == currentTariff)
                    {
                        Console.WriteLine("The selected tariff is already active. Please choose a different tariff or press 0 to go back.");
                        continue;
                    }

                    currentTariff = selectedTariff;
                    Console.WriteLine($"Tariff successfully changed to: {GetTariffName(currentTariff)}.");
 
                    return true;
                }
            }

            return HandleNext(request);
        }

        private string GetTariffName(int tariff)
        {
            string tariffName;
            switch (tariff)
            {
                case 1:
                    tariffName = "Base tariff";
                    break;
                case 2:
                    tariffName = "Standard tariff";
                    break;
                case 3:
                    tariffName = "Premium tariff";
                    break;
                default:
                    tariffName = "Unknown tariff";
                    break;
            }
            return tariffName;
        }
    }
}
