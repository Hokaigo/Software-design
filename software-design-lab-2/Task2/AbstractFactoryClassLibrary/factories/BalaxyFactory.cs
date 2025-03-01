using AbstractFactoryClassLibrary.devices.Balaxy;
using AbstractFactoryClassLibrary.devices.interfaces;
using AbstractFactoryClassLibrary.devices.Prone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.factories
{
    public class BalaxyFactory : IDeviceFactory
    {
        public IEBook CreateEBook() => new BalaxyEBook();
        public ILaptop CreateLaptop() => new BalaxyLaptop();
        public INetbook CreateNetbook() => new BalaxyNetbook();
        public ISmartphone CreateSmartphone() => new BalaxySmartphone();
    }
}
