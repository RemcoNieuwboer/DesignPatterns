using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Bridge
{
    public interface IBridge
    {
        string ImplementationOperation();
    }

    public class AbstractionObject
    {
        IBridge bridge;
        public AbstractionObject(IBridge implementation)
        {
            bridge = implementation;
        }

        public string Operation()
        {
            return "Operations that has to be run always + " + bridge.ImplementationOperation();
        }
    }

    public class ObjectVersion1 : IBridge
    {
        public string ImplementationOperation()
        {
            return "Operaration specific for version 1 of the object";
        }
    }

    public class ObjectVersion2 : IBridge
    {
        public string ImplementationOperation()
        {
            return "Operaration specific for version 2 of the object";
        }
    }
}