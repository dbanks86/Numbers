using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersUnitTests
{
    [TestClass]
    public class FibonacciLoopTests
    {
        [TestMethod]
        public void FibonacciLoop_NumberIsNegative_ShouldThrowInvalidOperationException()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            Action action = () => numbersUtility.FibonacciLoop(-1);

            // Assert
            Assert.ThrowsException<InvalidOperationException>(action);
        }

        [TestMethod]
        public void FibonacciLoop_NumberIs0_ShouldReturn0()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.FibonacciLoop(0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FibonacciLoop_NumberIs1_ShouldReturn1()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.FibonacciLoop(1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FibonacciLoop_NumberIs2_ShouldReturn1()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.FibonacciLoop(2);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FibonacciLoop_NumberIs6_ShouldReturn8()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.FibonacciLoop(6);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}
