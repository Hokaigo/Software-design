using AbstractFactoryClassLibrary.devices.interfaces;
using AbstractFactoryClassLibrary.devices.Prone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.factories
{
    public class IProneFactory : IDeviceFactory
    {
        public IEBook CreateEBook() => new IProneEBook();
        public ILaptop CreateLaptop() => new IProneLaptop();
        public INetbook CreateNetbook() => new IProneNetbook();
        public ISmartphone CreateSmartphone() => new IProneSmartphone();
    }
}
