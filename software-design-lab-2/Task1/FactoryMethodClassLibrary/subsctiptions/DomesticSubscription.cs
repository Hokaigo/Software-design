using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.subsctiptions
{
    public class DomesticSubscription : ISubscription
    {
        public string Name => "Домашня підписка";
        public decimal MonthlyPayment => 11.99M;
        public int MinPaymentPeriodInDays => 7;
        public List<string> Channels => new List<string> { "Lightning51", "YouAndWorld", "Straight24" };
        public List<string> Features => new List<string> { "Full HD", "Popular channels", "cheap for all family"};
    }
}
