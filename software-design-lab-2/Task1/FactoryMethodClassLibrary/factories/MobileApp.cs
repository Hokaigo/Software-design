using ClassLibrary.subsctiptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.factories
{
    public class MobileApp : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Subscribed via Mobile app.");
            return new EducationalSubscription();
        }
    }
}
