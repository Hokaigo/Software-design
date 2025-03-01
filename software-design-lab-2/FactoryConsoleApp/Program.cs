﻿using ClassLibrary.subsctiptions;
using ClassLibrary.factories;
using System;
using System.Text;

namespace FactoryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ISubscriptionFactory websiteFactory = new WebSite();
            ISubscription websiteSubscription = websiteFactory.CreateSubscription();
            PrintSubscriptionDetails(websiteSubscription);

            ISubscriptionFactory mobileAppFactory = new MobileApp();
            ISubscription mobileAppSubscription = mobileAppFactory.CreateSubscription();
            PrintSubscriptionDetails(mobileAppSubscription);

            ISubscriptionFactory managerCallFactory = new ManagerCall();
            ISubscription managerCallSubscription = managerCallFactory.CreateSubscription();
            PrintSubscriptionDetails(managerCallSubscription);
        }

        static void PrintSubscriptionDetails(ISubscription subscription)
        {
            Console.WriteLine($"Підписка: {subscription.Name}");
            Console.WriteLine($"Щомісячна плата: {subscription.MonthlyPayment} $");
            Console.WriteLine($"Мінімальний період підписки: {subscription.MinPaymentPeriodInDays} днів");
            Console.WriteLine($"Канали: {string.Join(", ", subscription.Channels)}");
            Console.WriteLine($"Можливості: {string.Join(", ", subscription.Features)}");
            Console.WriteLine();
        }
    }
}
