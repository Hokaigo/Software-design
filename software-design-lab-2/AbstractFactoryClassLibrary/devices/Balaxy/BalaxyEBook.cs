using AbstractFactoryClassLibrary.devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.devices.Balaxy
{
    public class BalaxyEBook : IEBook
    {
        public string ShowInfo() => "It's a Balaxy EBook";
    }
}
