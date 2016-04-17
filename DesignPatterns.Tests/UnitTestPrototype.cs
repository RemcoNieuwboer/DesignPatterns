using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Classes.Prototype;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class UnitTestPrototype
    {
        [TestMethod]
        public void Prototype()
        {
            var component = new Component();
            component.SetComponentData(Settings.SettingA);
            var componentclone = component.Clone();
            component.SetComponentData(Settings.SettingB);
            var cloneresult = componentclone.ToString();
            Assert.AreEqual(cloneresult, "componentdata: line, red, 33");     

            component.SetComponentData(Settings.SettingA);
            var componentcopy = component.Copy();
            component.SetComponentData(Settings.SettingB);
            var copyresult = componentcopy.ToString();
            Assert.AreEqual(copyresult, "componentdata: dots, green, 102");
       
        } 
    }
}
