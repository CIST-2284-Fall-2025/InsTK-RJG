// <copyright file="ICoursesDataService.cs" company="Rob Garner (rgarner7@cnm.edu)">
// Copyright (c) Rob Garner (rgarner7@cnm.edu). All rights reserved.
// </copyright>

namespace InsTK.Shared.Interfaces
{
    using InsTK.Shared.Models;

    /// <summary>
    /// Provides data access methods for <see cref="Course"/> entities.
    /// </summary>
    public interface ICoursesDataService
    {
        /// <summary>
        /// Asynchronously retrieves all courses.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="Course"/> objects.</returns>
        public Task<List<Course>> GetAllAsync();
    }
}
