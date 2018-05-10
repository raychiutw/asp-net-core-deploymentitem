using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeploymentItem.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var file = new StreamReader("TestData\\Sample.csv");
            // test code ...
        }
    }
}