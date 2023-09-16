using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShtolAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
           var name = "Александра";
           var res = DataService.GetMessage(name);
           Assert.AreEqual("Привет, Александра", res);
        }
    }
}
