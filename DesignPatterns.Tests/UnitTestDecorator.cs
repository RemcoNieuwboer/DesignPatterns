using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Decorator;

namespace Patterns.Tests
{
    [TestClass]
    public class UnitTestDecorator
    {
        [TestMethod]
        public void Decorator()
        {
            IComponent component = new Component();
            DecoratorA decoratora = new DecoratorA(component);
            DecoratorB decoratorb = new DecoratorB(component);
            IComponent decoratorab = new DecoratorB(decoratora);
            Assert.AreEqual(Decorate("Basic Component: ", component), "Basic Component: start value ");
            Assert.AreEqual(Decorate("Decorator A: ", decoratora), "Decorator A: start value and added value ");
            Assert.AreEqual(Decorate("Decorator B: ", decoratorb), "Decorator B: start value and other added value ");
            Assert.AreEqual(Decorate("Decorator A + B: ", decoratorab), "Decorator A + B: start value and added value and other added value ");
        }

        private string Decorate(string s, IComponent c)
        {
            return s + c.Operation();
        }
    }
}
