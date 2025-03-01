using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.subsctiptions
{
    internal class EducationalSubscription : ISubscription
    {
        public string Name => "Навчанльна підписка";
        public decimal MonthlyPayment => 4.99M;
        public int MinPaymentPeriodInDays => 7;
        public List<string> Channels => new List<string> { "Five+", "YouAndWorld", "Forward" };
        public List<string> Features => new List<string> { "Cheap for students", "All educational channels and more" };
    }
}
