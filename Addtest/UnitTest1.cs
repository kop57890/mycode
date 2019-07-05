using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddFunction;
namespace Addtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tmp = new Program();
            var first = 1;
            var sec = 1;
            var expect = 3;

            var actual = tmp.Add(first, sec);

            Assert.AreEqual(expect, actual);
        }
    }
}
