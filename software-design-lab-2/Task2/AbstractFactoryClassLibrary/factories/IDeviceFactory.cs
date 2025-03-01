using AbstractFactoryClassLibrary.devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.factories
{
    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        IEBook CreateEBook();
        INetbook CreateNetbook();
        ISmartphone CreateSmartphone();
    }
}
