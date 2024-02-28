using prjOOP;
namespace Test_Basic_OOP
{
    [TestClass]
    public class VeggieBurgerTest
    {
        VeggieBurger veggieBurger = new VeggieBurger();
        [TestMethod]
        public void testBun()
        {
            veggieBurger.getBun();
            veggieBurger.getBun(optionOne: "Rice Flour");
            string expected = "Plain Wheat";
            Assert.AreEqual(expected, veggieBurger.getBun());
        }

        [TestMethod]
        public void testPatty()
        {
            veggieBurger.getPatty();
            String expected = "Beef";
            Assert.AreNotEqual(expected,veggieBurger.getPatty());
        }
    }
}