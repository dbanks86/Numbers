﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersUnitTests
{
    [TestClass]
    public class IsPrimeTests
    {
        [TestMethod]
        public void IsPrime_NegativeNumber_False()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(-1);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_0_ExpectFalse()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(0);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_1_ExpectFalse()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(1);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_2_ExpectTrue()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPrime_3_ExpectTrue()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(3);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPrime_4_ExpectFalse()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(4);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_5_ExpectTrue()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(5);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPrime_6_ExpectFalse()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(6);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_7_ExpectTrue()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(7);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPrime_8_ExpectFalse()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(8);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_150_ExpectFalse()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(150);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_353_ExpectTrue()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.IsPrime(353);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
