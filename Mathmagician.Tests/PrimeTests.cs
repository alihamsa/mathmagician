using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void PrimeEnsureICanCreateInstance()
        {
            Prime my_Primes = new Prime();
            Assert.IsNotNull(my_Primes);
        }

        [TestMethod]
        public void PrimeEnsureICanGetFirst()
        {
            // Arrange
            Prime my_Primes = new Prime();

            // Act
            int actual = my_Primes.GetFirst();
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeEnsureICanGetNext()
        {
            // Arrange
            Prime my_Primes = new Prime();

            // Act
            int actual = my_Primes.GetNext(5);
            int expected = 7;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeIntegerEnsureICanCreateASequenceOfTen()
        {
            // Arrange
            Prime my_Primes = new Prime();

            // Act
            int[] actual = my_Primes.GetSequence(10);
            int[] expected = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
