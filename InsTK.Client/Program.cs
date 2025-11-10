using InsTK.Client;
using InsTK.Client.Data.Services;
using InsTK.Shared.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace InsTK.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddAuthorizationCore();
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

            // Add http client
            builder.Services.AddScoped(sp =>
            new HttpClient
            {
                BaseAddress = new Uri(builder.Configuration["FrontendUrl"] ??
                    "https://localhost:7150/")
            });

            // Data services
            builder.Services.AddTransient<ICoursesDataService, CoursesClientDataService>();

            await builder.Build().RunAsync();
        }
    }
}
