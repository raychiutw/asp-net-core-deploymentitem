using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeploymentItem.Tests
{
    [TestClass]
    public class UnitTestWithDeploymentItem
    {
        [TestMethod]
        [DeploymentItem("TestData\\Sample.csv")]
        public void TestMethod1()
        {
            var file = new StreamReader("Sample.csv");
            // test code ...
        }
    }
}