using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;
using System;

namespace NumbersUnitTests
{
    [TestClass]
    public class OrderByDigitDescendingTests
    {
        [TestMethod]
        public void OrderByDigitDescendingTests_NumberIsNegative_ExpectInvalidOperationException()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            Action action = () => numbersUtility.OrderByDigitDescending(-1);

            // Assert
            Assert.ThrowsException<InvalidOperationException>(action);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_0_Expect0()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_1_Expect1()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_123_Expect321()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(123);

            // Assert
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_132_Expect321()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(132);

            // Assert
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_213_Expect321()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(213);

            // Assert
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_231_Expect321()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(231);

            // Assert
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_312_Expect321()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(312);

            // Assert
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_321_Expect321()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(321);

            // Assert
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_156165158_Expect866555111()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(866555111);

            // Assert
            Assert.AreEqual(866555111, result);
        }

        [TestMethod]
        public void OrderByDigitDescendingTests_9966118833_Expect9988663311()
        {
            // Arrange
            NumbersUtility numbersUtility = new NumbersUtility();

            // Act
            var result = numbersUtility.OrderByDigitDescending(9988663311);

            // Assert
            Assert.AreEqual(9988663311, result);
        }
    }
}
