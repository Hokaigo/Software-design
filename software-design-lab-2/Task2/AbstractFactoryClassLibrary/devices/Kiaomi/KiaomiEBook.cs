using AbstractFactoryClassLibrary.devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.devices.Kiaomi
{
    public class KiaomiEBook : IEBook
    {
        public string ShowInfo() => "It's a Kiaomi EBook";
    }
}
