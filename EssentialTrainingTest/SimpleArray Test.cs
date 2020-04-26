using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining; // have to add using statement each time you create a test class
// this will be the namespace of whatever you are testing

namespace EssentialTrainingTest
{
    [TestClass]
    public class SimpleArray_Test
    {
        [TestMethod]
        public void TestInstantation()
        {
            var testInstance = new SimpleArray();

            Assert.AreEqual(testInstance.GroceryList.Length, 4);
            Assert.AreEqual(testInstance.GroceryList[1], "Milk");
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
              
        }
    }
}
