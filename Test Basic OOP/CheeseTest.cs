using Microsoft.VisualStudio.TestTools.UnitTesting;
using prjOOP;

namespace Test_Basic_OOP
{
    [TestClass]
     public class CheeseTest
    {
        CheeseBurger cheeseBurger = new CheeseBurger();
        [TestMethod]
        public void TestAddCheddar()
        {
            string expectedCheddar = "Cheddar";
            Assert.AreEqual(expectedCheddar, cheeseBurger.AddCheddar());
        }
        [TestMethod]
        public void testCheese()
        {
            String expectedChadar = "Cheddar";
            Assert.AreEqual(expectedChadar, cheeseBurger.AddCheddar());
            String expected = "Chedar";
            Assert.AreNotEqual(expected, cheeseBurger.AddCheddar());

        }
    }
}
