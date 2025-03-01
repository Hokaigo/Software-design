using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.subsctiptions
{
    public interface ISubscription
    {
        string Name { get; }
        decimal MonthlyPayment { get; }
        int MinPaymentPeriodInDays { get; }
        List<string> Channels { get; }
        List<string> Features { get; }
    }
}
