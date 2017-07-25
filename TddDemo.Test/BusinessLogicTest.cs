using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TddDemo.Test
{
    [TestClass]
    public class BusinessLogicTest
    {
        // Remember Arrange - Act - Assert :)
        [TestMethod]
        public void Execute_WithPositiveNumber_ReturnsNumber()
        {
            var mock = new Mock<IDependency>();
            mock.Setup(m => m.GetResult()).Returns(1);
            var logic = new BusinessLogic(mock.Object);

            var res = logic.Execute();

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Execute_WithOtherPositiveNumber_ReturnsNumber()
        {
            var expected = 2;
            var mock = new Mock<IDependency>();
            mock.Setup(m => m.GetResult()).Returns(2);
            var logic = new BusinessLogic(mock.Object);

            var res = logic.Execute();

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Execute_WithNegativeNumber_ThrowsException()
        {
            var expected = -2;
            var mock = new Mock<IDependency>();
            mock.Setup(m => m.GetResult()).Returns(expected);
            var logic = new BusinessLogic(mock.Object);

            var res = logic.Execute();
        }

        [TestMethod]
        public void BraNavn()
        {
            var mock = new Mock<IDependency>();
            var e = new Exception("feilmelding");
            mock.Setup(m => m.GetResult()).Throws(e);

            
        }
    }
}
