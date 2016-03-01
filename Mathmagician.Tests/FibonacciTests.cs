using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateInstance()
        {
            Fibonacci my_Fibonacci = new Fibonacci();
            Assert.IsNotNull(my_Fibonacci);
        }

        [TestMethod]
        public void FibonacciEnsureICanGetFirst()
        {
            // Arrange
            Fibonacci my_Fibonacci = new Fibonacci();

            // Act
            int actual = my_Fibonacci.GetFirst();
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciEnsureICanGetNext()
        {
            // Arrange
            Fibonacci my_Fibonacci = new Fibonacci();

            // Act
            int actual = my_Fibonacci.GetNext(6);
            int expected = 8;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciIntegerEnsureICanCreateASequenceOfTen()
        {
            // Arrange
            Fibonacci my_Fibonacci = new Fibonacci();

            // Act
            int[] actual = my_Fibonacci.GetSequence(10);
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34};

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void FibonacciCalcNthFibonacciNumber()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetNth(2);
            int expected = 1; 

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
