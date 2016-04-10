using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Bridge;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class BridgeTest
    {
        [TestMethod]
        public void Bridge()
        {
            IBridge objectversion1 = new ObjectVersion1();
            var objectversion2 = new ObjectVersion2();
            Assert.AreEqual(new AbstractionObject(objectversion1).Operation(), "Operations that has to be run always + Operaration specific for version 1 of the object");
            Assert.AreEqual(new AbstractionObject(objectversion2).Operation(), "Operations that has to be run always + Operaration specific for version 2 of the object");
        }
    }
}
