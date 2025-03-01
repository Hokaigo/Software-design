using ClassLibrary.subsctiptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.factories
{
    public class WebSite : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Subscribed via Website.");
            return new DomesticSubscription();
        }
    }
}
