﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalctrainerContracts.models
{
    public struct Profile
    {
        public Profile(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
