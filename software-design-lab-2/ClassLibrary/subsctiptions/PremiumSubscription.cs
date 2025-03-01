using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.subsctiptions
{
    public class PremiumSubscription : ISubscription
    {
        public string Name => "Преміум підписка";
        public decimal MonthlyPayment => 14.99M;
        public int MinPaymentPeriodInDays => 7;
        public List<string> Channels => new List<string> { "Five+", "YouAndWorld", "Forward", "Lightning51", "YouAndWorld", "Straight24" };
        public List<string> Features => new List<string> { "Almost all channels", "full HD", "updates notification" };
    }
}
