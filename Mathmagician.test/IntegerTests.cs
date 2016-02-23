using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.test
{
    [TestClass]
    public class IntergerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {
            Integer my_int = new Integer();
            Assert.IsNotNull(my_int);
        }

        [TestMethod]
        public void IntegerEnsureIcanGetFirstNumber()
        {
            // Arrange -I Scenario Setup
            Integer my_int = new Integer();

            // Act - Do the thing you want to test
            int actual = my_int.GetFirst();
            int expected = 0;
            // Assert - Did it work as expected?
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntegerEnsureICanGetNextInteger()
        {
            //Arrange
            Integer my_int = new Integer();
            //Act
            int actual = my_int.GetNext(5);
            int expected = 6;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IntegerEnsureICanCreateASequenceofTenIntegers()
        {
            //Arrange
            Integer my_int = new Integer();

            //Act
            int[] actual = my_int.GetSequence(10);
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
