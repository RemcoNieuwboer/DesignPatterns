using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Composite;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class UnitTestComposite
    {
        [TestMethod]
        public void Composite()
        {
            IComponent<string> root = new Composite<string>("root");
            IComponent<string> item1 = new Composite<string>("item1");
            IComponent<string> item11 = new Composite<string>("item1.1");
            IComponent<string> item111 = new Component<string>("item1.1.1");
            IComponent<string> item112 = new Component<string>("item1.1.2");
            IComponent<string> item12 = new Composite<string>("item1.2");
            IComponent<string> item2 = new Composite<string>("item2");
            IComponent<string> item21 = new Component<string>("item2.1");
            IComponent<string> item3 = new Composite<string>("item3");
            IComponent<string> item31 = new Component<string>("item3.1");

            //set item1
            item11.Add(item111);
            item11.Add(item112);
            item1.Add(item11);
            item1.Add(item12);
            root.Add(item1);

            //set item2
            item2.Add(item21);
            root.Add(item2);

            //set item3
            item3.Add(item31);
            root.Add(item3);

            var result = root.Display(0);

            Assert.AreEqual(result, "root: 3 items in list\n--item1: 2 items in list\n----item1.1: 2 items in list\n------item1.1.1\n------item1.1.2\n----item1.2: 0 items in list\n--item2: 1 items in list\n----item2.1\n--item3: 1 items in list\n----item3.1\n");

        }
    }
}
