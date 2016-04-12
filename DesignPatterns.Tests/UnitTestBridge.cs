using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Bridge;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class UnitTestBridge
    {
        [TestMethod]
        public void Bridge()
        {
            IBridge object1 = new Object1();
            IBridge object2 = new Object2();
            Assert.AreEqual(new Abstraction(object1).Operation(), "Operaration specific for object1");
            Assert.AreEqual(new Abstraction(object2).Operation(), "Operaration specific for object2");
        }
    }
}
