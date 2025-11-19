// <copyright file="CoursesPageVM.cs" company="Rob Garner (rgarner7@cnm.edu)">
// Copyright (c) Rob Garner (rgarner7@cnm.edu). All rights reserved.
// </copyright>

namespace InsTK.Shared.ViewModels
{
    using System.Collections.Generic;
    using InsTK.Shared.Models;

    /// <summary>
    /// ViewModel for the Courses page, containing a list of courses and a selected course.
    /// </summary>
    public class CoursesPageVM
    {
        /// <summary>
        /// Gets or sets the list of courses.
        /// </summary>
        public List<Course>? Courses { get; set; }

        /// <summary>
        /// Gets or sets the selected course.
        /// </summary>
        public Course? Course { get; set; }
    }
}
