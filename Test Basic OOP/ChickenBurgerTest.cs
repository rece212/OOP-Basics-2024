using prjOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Basic_OOP
{
    [TestClass]
    public class ChickenBurgerTest
    {
          ChickenBurger cb = new ChickenBurger();
        [TestMethod]
        public void FailedTestChicken()
        {
            string expected = "Chicken";
            Assert.AreNotEqual(expected, cb.getBun());
        }
    }
}
