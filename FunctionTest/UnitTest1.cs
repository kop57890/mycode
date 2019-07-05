using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using AddFunction;

namespace FunctionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = AddMethod.Add(1, 2);
            var expect = 3;
            Assert.AreEqual(expect, actual);
        }
    }
}
