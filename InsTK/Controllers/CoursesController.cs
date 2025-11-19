// <copyright file="ValuesController.cs" company="Rob Garner (rgarner7@cnm.edu)">
// Copyright (c) Rob Garner (rgarner7@cnm.edu). All rights reserved.
// </copyright>

namespace InsTK.Controllers
{
    using InsTK.Shared.Interfaces;
    using InsTK.Shared.Models;
    using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await dataService?.GetAllAsync());
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task AddAsync(Course course)
        {
            await this.dataService.AddAsync(course);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task UpdateAsync(Course course)
        {
            await this.dataService.UpdateAsync(course);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        [Route("{id}")]
        public async Task DeleteAsync(string id)
        {
            await this.dataService.DeleteAsync(id);
        }
    }
}
