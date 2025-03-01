using ClassLibrary.subsctiptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.factories
{
    public interface ISubscriptionFactory
    {
        ISubscription CreateSubscription();
    }
}
