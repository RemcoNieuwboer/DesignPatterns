using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Factory;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class UnitTestFactory
    {
        [TestMethod]
        public void Factory()
        {
            Creator c = new Creator();
            List<string> list = new List<string>();
            for (int i = 0; i < 11; i++)
            {
                var component = c.FactoryMethod(i);
                list.Add(component.Value());
            }
            Assert.AreEqual(list[0], "ComponentA");
            Assert.AreEqual(list[1], "ComponentA");
            Assert.AreEqual(list[2], "ComponentA");
            Assert.AreEqual(list[3], "ComponentA");
            Assert.AreEqual(list[4], "ComponentA");
            Assert.AreEqual(list[5], "ComponentB");
            Assert.AreEqual(list[6], "ComponentB");
            Assert.AreEqual(list[7], "ComponentB");
            Assert.AreEqual(list[8], "ComponentB");
            Assert.AreEqual(list[9], "ComponentB");
            Assert.AreEqual(list[10], "not available");
        }
    }
}
