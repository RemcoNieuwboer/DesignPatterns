using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Flyweight;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class UnitTestFlyweight
    {
        [TestMethod]
        public void Flyweight()
        {
            FLyweightFactory factory = new FLyweightFactory();
            factory["item1"].Operation("somevalue");
            Assert.AreEqual(factory.Count(), 1);

            factory["item2"].Operation("another value");
            Assert.AreEqual(factory.Count(), 2);

            Assert.AreEqual(factory["item1"].IntrinsicState, "somevalue");
            Assert.AreEqual(factory["item2"].IntrinsicState, "another value");
            Assert.AreEqual(factory.Count(), 2);

            factory["item1"].Operation("somevalue changed");
            factory["item2"].Operation("another value changed");
            Assert.AreEqual(factory.Count(), 2);

            Assert.AreEqual(factory["item1"].IntrinsicState, "somevalue changed");
            Assert.AreEqual(factory["item2"].IntrinsicState, "another value changed");
            Assert.AreEqual(factory.Count(), 2);
        }
    }
}
