using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDemo.Test
{
    // Class must have TestClass attribute
    [TestClass]
    public class CanaryTestClass
    {
        // Method must have TestMethod attribute
        [TestMethod]
        public void CanaryTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.IsTrue(false);
        }

        public void MissingAttributeWillNotRun()
        {
            Assert.IsTrue(false);
        }

    }
}
