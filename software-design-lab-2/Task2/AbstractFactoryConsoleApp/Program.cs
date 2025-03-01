using AbstractFactoryClassLibrary.factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            IDeviceFactory iProneFactory = new IProneFactory();
            IDeviceFactory kiaomiFactory = new KiaomiFactory();
            IDeviceFactory balaxyFactory = new BalaxyFactory();

            Console.WriteLine("iProne Devices:");
            ShowDevicesInfo(iProneFactory);

            Console.WriteLine("\nKiaomi Devices:");
            ShowDevicesInfo(kiaomiFactory);

            Console.WriteLine("\nBalaxy Devices:");
            ShowDevicesInfo(balaxyFactory);
        }

        static void ShowDevicesInfo(IDeviceFactory factory)
        {
            Console.WriteLine(factory.CreateLaptop().ShowInfo());
            Console.WriteLine(factory.CreateNetbook().ShowInfo());
            Console.WriteLine(factory.CreateEBook().ShowInfo());
            Console.WriteLine(factory.CreateSmartphone().ShowInfo());
        }
    }
}
