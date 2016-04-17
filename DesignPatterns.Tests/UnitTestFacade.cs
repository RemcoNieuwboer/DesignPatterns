
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Facade;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class UnitTestFacade
    {
        [TestMethod]
        public void Facade()
        {
            //Class Internal is not visible
            var facade = new Facade();
            facade.Operation();
        }
    }
}
