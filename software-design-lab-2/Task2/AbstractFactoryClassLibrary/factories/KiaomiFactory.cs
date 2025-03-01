using AbstractFactoryClassLibrary.devices.interfaces;
using AbstractFactoryClassLibrary.devices.Kiaomi;
using AbstractFactoryClassLibrary.devices.Prone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.factories
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IEBook CreateEBook() => new KiaomiEBook();
        public ILaptop CreateLaptop() => new KiaomiLaptop();
        public INetbook CreateNetbook() => new KiaomiNetbook();
        public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
    }
}
