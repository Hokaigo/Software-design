﻿using AbstractFactoryClassLibrary.devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.devices.Prone
{
    public class IProneEBook : IEBook
    {
        public string ShowInfo() => "It's a Prone EBook";
    }
}
