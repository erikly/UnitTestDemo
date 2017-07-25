using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;

namespace UnitTest.Test
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void Test()
        {
            var testplayer = new Player();

            testplayer.SpecialEvent();

        }
    }
}
