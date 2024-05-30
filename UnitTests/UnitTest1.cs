using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PROG6221POEPART2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private Methods methods; // Declare a private instance of the Methods class

        [TestInitialize]
        public void Initialize()
        {
            methods = new Methods(); // Initialize the instance of the Methods class
        }

        [TestMethod]
        public void TestScaleRecipe()
        {
            // Arrange
            var expected = "Recipe Successfully Scaled!";

            // Act
            var actual = methods.ScaleRecipe();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
