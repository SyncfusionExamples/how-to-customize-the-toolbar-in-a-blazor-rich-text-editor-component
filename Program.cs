using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Blazor;

namespace MyBlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTE3NzEzQDMxMzkyZTMzMmUzMENjeTNVMTdhNkZRUXE0YkcxZTRTK1dSdit6dDhYSS9tUXFzK0Y4U3JFM3M9");
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }

    }
}
