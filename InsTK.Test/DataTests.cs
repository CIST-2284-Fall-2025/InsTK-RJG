namespace InsTK.Test
{
    using InsTK.Server.Data.Mocks;
    using InsTK.Shared.Models;
    using System.Threading.Tasks;

    [TestClass]
    public sealed class DataTests
    {
        [TestMethod]
        public async Task CoursesDataServiceMockReturnsAListOfCoursesAsync()
        {
            var classUnderTest = new CourseDataServiceMock();
            var actualResult = await classUnderTest.GetAllAsync();
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOfType<List<Course>>(actualResult);
        }
    }
}
