﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Bridge
{
    public class Object2 : IBridge
    {
        public string Operation()
        {
            return "Operaration specific for object2";
        }
    }
}