// <copyright file="InsTKStringUtilitiesTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UtilitiesTests
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
    using Utilities;

    /// <summary>
    /// Contains unit tests for the <see cref="InsTKStringUtilities"/> class.
    /// </summary>
    [TestClass]
    public sealed class InsTKStringUtilitiesTests
    {
        /// <summary>
        /// Tests that one 'y' is found in "mysterious".
        /// </summary>
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";  
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new InsTKStringUtilities();
            int actualResult = classUnderTest.CountOccurances(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests that two 's' are found in "mysterious".
        /// </summary>
        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new InsTKStringUtilities();
            var actualResult = classUnderTest.CountOccurances(stringToCheck,stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests that the search is case-insensitive.
        /// </summary>
        [TestMethod]
        public void SearchShouldBeCaseInsensitive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new InsTKStringUtilities();
            var actualResult = classUnderTest.CountOccurances(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests that the search is case-insensitive when the string to find is uppercase.
        /// </summary>
        [TestMethod]
        public void SearchShouldBeCaseInsensitiveGivenUppercaseStringToFind()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "S";
            var expectedResult = 2;
            var classUnderTest = new InsTKStringUtilities();
            var actualResult = classUnderTest.CountOccurances(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests that null input is handled correctly.
        /// </summary>
        [TestMethod]
        public void ShoulhBeAbleToHandleNulls()
        {
            var stringToCheck = (string?)null;
            var stringToFind = "s";
            var expectedResult = -1;
            var classUnderTest = new InsTKStringUtilities();
            var actualResult = classUnderTest.CountOccurances(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests that not finding the string returns 0.
        /// </summary>
        [TestMethod]
        public void NotFoundShouldReturnMinus1()
        {
            var stringToCheck ="mysterious";
            var stringToFind = "z";
            var expectedResult = 0;
            var classUnderTest = new InsTKStringUtilities();
            var actualResult = classUnderTest.CountOccurances(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
