using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestDemo;
using UnitTestDemo.DependencyInjection;

namespace UnitTest.Test
{
    [TestClass]
    public class PlayerWithMoqTest
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void TestMethod1()
        {
            var mockDie = new Mock<IDie>();
            mockDie.Setup(m => m.GetDieRoll()).Returns(6);
            var die = mockDie.Object;
            var player = new PlayerWithDie(die);

            player.TakeTurn();

            mockDie.Verify(m => m.GetDieRoll(), Times.Exactly(2));
        }
    }
}
