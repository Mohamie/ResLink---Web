using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ResLink.BL.BackendlessInit;
namespace ResLink.Client
{
    public class Program
    {
        private static string APPLICATIONID = "B5ACCDD7-2895-D5A4-FFF1-63C024AFED00";
        private static string APIKEY = "E68870EC-779E-4591-A4F5-A426E26023EE";

        public static async Task Main(string[] args)
        {
            BackendlessAPI.Backendless.InitApp(APPLICATIONID, APIKEY);

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();

        }
    }
}
