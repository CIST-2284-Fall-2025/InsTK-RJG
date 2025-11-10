using InsTK.Shared.Interfaces;
using InsTK.Shared.Models;
using System.Net.Http.Json;

namespace InsTK.Client.Data.Services
{
    public class CoursesClientDataService : ICoursesDataService
    {
        private readonly HttpClient http;

        public CoursesClientDataService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Course>> GetAllAsync()
        {
            var courses = await http.GetFromJsonAsync<List<Course>>("/api/Courses");
            if (courses == null)
            {
                return new List<Course>();
            }
            else
            {
                return courses;
            }
        }

        public Task AddAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
