using System;

namespace Task1ClassLibrary
{
    public class SpecialOffersHandler : Handler
    {
        public override bool Handle(SupportedRequestType request)
        {
            if (request == SupportedRequestType.SpecialOffers)
            {
                Console.WriteLine("Your special offers:");
                Console.WriteLine("Discount for a 20% for standard tariff for 3 months.");
                Console.WriteLine("Get 20 uah on balance for doing");
                return true;
            }
            return HandleNext(request);
        }
    }
}
