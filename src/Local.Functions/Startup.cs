using System;
using System.IO;
using Local.Functions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Playwright;
using Microsoft.Extensions.Configuration;


[assembly: FunctionsStartup(typeof(Startup))]

namespace Local.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            DirectoryInfo assemblyDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            Console.WriteLine(assemblyDirectory.FullName);
            // var exitCode = Program.Main(new[] { "install", "--with-deps", "chromium" });
            // if (exitCode != 0)
            // {
            //     throw new Exception($"Playwright exited with code {exitCode}");
            // }
        }
    }
}