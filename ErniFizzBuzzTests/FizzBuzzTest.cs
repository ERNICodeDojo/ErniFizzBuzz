using System;
using System.Collections.Generic;
using System.Linq;
using ErniFizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ErniFizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        /// <summary>
        /// Tests the fizz buzz creates new fizz buzz object returns object.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_CreatesNewFizzBuzzObject_ReturnsObject()
        {
            // Arrange
            // Act
            // Assert
            Assert.IsNotNull(new FizzBuzz());
        }

        /// <summary>
        /// Tests the fizz buzz creates new fizz buzz object returns empty list.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_CreatesNewFizzBuzzObject_ReturnsEmptyList()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = new List<string>();

            // Act
            var emptyList = fizzBuzz.GetFizzBuzz(0);

            // Assert
            CollectionAssert.AreEqual(expected, emptyList.ToList());
        }

        /// <summary>
        /// Tests the fizz buzz get fizz buzz with an invalid number throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "-1 must be positive")]
        public void TestFizzBuzz_GetFizzBuzzWithAnInvalidNumber_ThrowsException()
        {
            // Arrange
            var fizzBuz = new FizzBuzz();
            
            // Act
            fizzBuz.GetFizzBuzz(-1);
        }

        /// <summary>
        /// Tests the fizz buzz get fizz buzz two returns two numbers.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_GetFizzBuzzTwo_ReturnsTwoNumbers()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = new List<string> { "1", "2" };

            // Act
            var real = fizzBuzz.GetFizzBuzz(2);

            // Assert
            CollectionAssert.AreEqual(expected, real.ToList());
        }

        /// <summary>
        /// Tests the fizz buzz get fizz buzz five items.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_GetFizzBuzzFiveItems()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };

            // Act
            var real = fizzBuzz.GetFizzBuzz(5);

            // Assert
            CollectionAssert.AreEqual(expected, real.ToList());
        }

        /// <summary>
        /// Tests the fizz buzz get fizz buzz fizz buzz.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_GetFizzBuzz_FizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = "FizzBuzz";

            // Act
            var real = fizzBuzz.GetFizzBuzz(15).ToList()[14];

            // Assert
            Assert.AreEqual(expected, real);
        }

        /// <summary>
        /// Tests the fizz buzz get fizz buzz seven items.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_GetFizzBuzzSevenItems()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "Whizz" };

            // Act
            var real = fizzBuzz.GetFizzBuzz(7);

            // Assert
            CollectionAssert.AreEqual(expected, real.ToList());
        }

        /// <summary>
        /// Tests the fizz buzz get fizz whizz fizz whizz.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_GetFizzWhizz_FizzWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = "FizzWhizz";

            // Act
            var real = fizzBuzz.GetFizzBuzz(21).ToList()[20];

            // Assert
            Assert.AreEqual(expected, real);
        }

        /// <summary>
        /// Tests the fizz buzz get buzz whizz buzz whizz.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz_GetBuzzWhizz_BuzzWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = "BuzzWhizz";

            // Act
            var real = fizzBuzz.GetFizzBuzz(35).ToList()[34];

            // Assert
            Assert.AreEqual(expected, real);
        }
    }
}
