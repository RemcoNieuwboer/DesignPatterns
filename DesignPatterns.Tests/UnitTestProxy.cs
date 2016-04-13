using DesignPatterns.Classes.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Patterns.Tests
{
    [TestClass]
    public class UnitTestProxy
    {
        [TestMethod]
        public void Proxy()
        {
            RealSubject realsubject = new RealSubject();
            Assert.AreEqual(realsubject.DoAction(), "do action");

            VirtualProxy subject = new VirtualProxy();
            Assert.AreEqual(subject.DoAction(), "Virtual Proxy: Call to do action");

            ProtectionProxy protectedsubject = new ProtectionProxy();
            Assert.AreEqual(protectedsubject.DoAction(), "Protection Proxy: Authenticate first");

            var result = protectedsubject.Authenticate("somepassword");
            Assert.AreEqual(result, "Protection proxy: No Access");
            Assert.AreEqual(protectedsubject.DoAction(), "Protection Proxy: Authenticate first");

            result = protectedsubject.Authenticate("mypassword");
            Assert.AreEqual(result, "Protection proxy: Authenticated");
            Assert.AreEqual(protectedsubject.DoAction(), "Protection Proxy: Call to do action");
        }
    }
}
