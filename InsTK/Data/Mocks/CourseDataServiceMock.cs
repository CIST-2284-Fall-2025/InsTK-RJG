// <copyright file="CourseDataServiceMock.cs" company="Rob Garner (rgarner7@cnm.edu)">
// Copyright (c) Rob Garner (rgarner7@cnm.edu). All rights reserved.
// </copyright>
namespace InsTK.Data.Mocks
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using InsTK.Shared.Interfaces;
    using InsTK.Shared.Models;

    /// <summary>
    /// Mock implementation of <see cref="ICoursesDataService"/> for testing and development purposes.
    /// Provides a static list of <see cref="Course"/> objects.
    /// </summary>
    public class CourseDataServiceMock : ICoursesDataService
    {
        /// <summary>
        /// The in-memory list of <see cref="Course"/> objects used by the mock service.
        /// </summary>
        private readonly List<Course> courses =
        [
            new Course
            {
                Id = Guid.NewGuid().ToString(),
                Number = "CIST 1220",
                Name = "Programming Fundamentals",
                Description = "An intro course for new programmers",
            },

            new Course
            {
                Id = Guid.NewGuid().ToString(),
                Number = "CSCI 1220",
                Name = "Python I",
                Description = "An introduction to programming with Python",
            },

            new Course
            {
                Id = Guid.NewGuid().ToString(),
                Number = "CIST 2284",
                Name = ".NET II",
                Description = "Web development with .NET",
            },
        ];

        /// <summary>
        /// Asynchronously retrieves all courses from the mock data source.
        /// </summary>
        /// <returns>
        /// A <see cref="Task{TResult}"/> representing the asynchronous operation.
        /// The task result contains a list of <see cref="Course"/> objects.
        /// </returns>
        public Task<List<Course>> GetAllAsync()
        {
            return Task.FromResult(this.courses);
        }
    }
}
