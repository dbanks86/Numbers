using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersUnitTests
{
    [TestClass]
    public class OrderByDigitTests
    {
        [TestMethod]
        public void OrderByDigitTests_NumberIsNegative_ExpectInvalidOperationException()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            Action action = () => numbersUtility.OrderByDigit(-1);

            // Assert
            Assert.ThrowsException<InvalidOperationException>(action);
        }

        [TestMethod]
        public void OrderByDigitTests_0_Expect0()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void OrderByDigitTests_1_Expect1()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OrderByDigitTests_123_Expect123()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(123);

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void OrderByDigitTests_132_Expect123()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(132);

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void OrderByDigitTests_213_Expect123()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(213);

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void OrderByDigitTests_231_Expect123()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(231);

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void OrderByDigitTests_312_Expect123()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(312);

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void OrderByDigitTests_321_Expect123()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(321);

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void OrderByDigitTests_156165158_Expect111555668()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(866555111);

            // Assert
            Assert.AreEqual(111555668, result);
        }

        [TestMethod]
        public void OrderByDigitTests_9966118833_Expect1133668899()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigit(9988663311);

            // Assert
            Assert.AreEqual(1133668899, result);
        }
    }
}
