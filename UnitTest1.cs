using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;

            Assert.AreNotEqual(a,b);
        }
    }
}
