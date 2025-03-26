using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtility;

namespace TestStringUtility
{
    [TestClass]
    public class StringUtilityTests
    {
        private StringUtility.StringUtility _stringUtility;

        [TestInitialize]
        public void Setup()
        {
            _stringUtility = new StringUtility.StringUtility();
        }

        // Test Case 1: Testing with a single occurrence
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            // Act
            var result = _stringUtility.CountOccurrences("mysterious", 'y');

            // Assert
            Assert.AreEqual(1, result);
        }

        // Test Case 2: Testing find multiple occurrences
        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            // Act
            var result = _stringUtility.CountOccurrences("mysterious", 's');

            // Assert
            Assert.AreEqual(2, result);
        }

        // Test Case 3: Testing with uppercase sensitivity
        [TestMethod]
        public void SearchShouldBeCaseSensitive()
        {
            // Act
            var result = _stringUtility.CountOccurrences("mySterious", 's');

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
