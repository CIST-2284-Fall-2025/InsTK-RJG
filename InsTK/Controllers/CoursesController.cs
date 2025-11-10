// <copyright file="ValuesController.cs" company="Rob Garner (rgarner7@cnm.edu)">
// Copyright (c) Rob Garner (rgarner7@cnm.edu). All rights reserved.
// </copyright>

namespace InsTK.Controllers
{
    using InsTK.Shared.Interfaces;
    using InsTK.Shared.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")] // api/Courses
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesDataService dataService;

        public CoursesController(ICoursesDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet]
        public async Task<List<Course>?> GetAllAsync()
        {
            return await dataService?.GetAllAsync();
        }

    }
}
