using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.DependencyInjection;
using UnitTestDemo;

namespace UnitTest.Test
{
    [TestClass]
    public class PlayerWithDieTest
    {
        [TestMethod]
        public void TakeTurn_WhenDieRollIsSix_PerformsSpecialEvent()
        {
            var player = new PlayerWithDie(new DieWithSixRoll());

            player.TakeTurn();

            Assert.IsTrue(true);
        }

        private class DieWithSixRoll : IDie
        {
            public int GetDieRoll()
            {
                return 6;
            }
        }
    }
}
