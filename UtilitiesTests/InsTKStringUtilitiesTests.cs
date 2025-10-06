using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Utilities;

namespace UtilitiesTests
{
    [TestClass]
    public sealed class InsTKStringUtilitiesTests
    {
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
