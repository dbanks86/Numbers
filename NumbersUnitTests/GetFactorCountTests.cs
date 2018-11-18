using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersUnitTests
{
    [TestClass]
    public class GetFactorCountTests
    {
        [TestMethod]
        public void GetFactorCount_NumberIsNegative_ExpectInvalidOperationException()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            Action action = () => numbersUtility.GetFactorCount(-1);

            // Assert
            Assert.ThrowsException<InvalidOperationException>(action);
        }

        [TestMethod]
        public void GetFactorCount_0_Expect0()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetFactorCount_1_Expect1()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetFactorCount_2_Expect2()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetFactorCount_3_Expect2()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(3);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetFactorCount_4_Expect3()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(4);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetFactorCount_5_Expect2()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(5);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetFactorCount_6_Expect4()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(6);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetFactorCount_7_Expect2()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(7);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetFactorCount_8_Expect4()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(8);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetFactorCount_24_Expect8()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(24);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void GetFactorCount_50_Expect6()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.GetFactorCount(50);

            // Assert
            Assert.AreEqual(6, result);
        }
    }
}
