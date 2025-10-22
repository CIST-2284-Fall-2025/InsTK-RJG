// <copyright file="CoursesDataService.cs" company="Rob Garner (rgarner7@cnm.edu)">
// Copyright (c) Rob Garner (rgarner7@cnm.edu). All rights reserved.
// </copyright>

namespace InsTK.Data.Services
{
    using InsTK.Shared.Interfaces;
    using InsTK.Shared.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Provides data operations for <see cref="Course"/> entities.
    /// </summary>
    public class CoursesDataService : ICoursesDataService
    {
        private readonly ApplicationDbContext context;

        public CoursesDataService(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets all courses asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of courses.</returns>
        public async Task<List<Course>> GetAllAsync()
        {
            return await context.Courses.ToListAsync();
        }

        /// <summary>
        /// Adds a new course asynchronously.
        /// </summary>
        /// <param name="course">The course to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task AddAsync(Course course)
        {
            course.Id = Guid.NewGuid().ToString();
            context.Courses.Add(course);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates an existing course asynchronously.
        /// </summary>
        /// <param name="course">The course to update.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task UpdateAsync(Course course)
        {
            // Find the one in the database
            var curentCourse = await context.Courses.Where(c=>c.Id == course.Id).FirstOrDefaultAsync();

            // Update it from the values in the parameter course
            curentCourse.Number = course.Number;
            curentCourse.Name = course.Name;
            curentCourse.Description = course.Description;

            // Save changes.
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a course asynchronously.
        /// </summary>
        /// <param name="course">The course to delete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task DeleteAsync(Course course)
        {
            // Find the one in the database
            var curentCourse = await context.Courses.Where(c => c.Id == course.Id).FirstOrDefaultAsync();
            context.Courses.Remove(curentCourse);
            await context.SaveChangesAsync();
        }
    }
}
