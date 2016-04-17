
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Adapter;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class UnitTestAdapter
    {
        [TestMethod]
        public void Adapter()
        {
            AdapteeA adaptee1 = new AdapteeA();
            double resultadaptee1 = adaptee1.SpecificRequest(5, 3);
            double a = 5;
            double b = 3;
            Assert.AreEqual(resultadaptee1, a / b);

            Adapter adapter1 = new Adapter(adaptee1);
            string resultadapter1 = adapter1.Request(5, 3);
            Assert.AreEqual(resultadapter1, "Rounded result is: 2");

            AdapteeB adaptee2 = new AdapteeB();
            double resultadaptee2 = adaptee2.SpecificRequest(5, 3);
            Assert.AreEqual(resultadaptee2, 5 + 3);

            Adapter adapter2 = new Adapter(adaptee2);
            string resultadapter2 = adapter2.Request(5, 3);
            Assert.AreEqual(resultadapter2, "Rounded result is: 8");
        }
    }
}
