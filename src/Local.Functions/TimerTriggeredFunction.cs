using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Playwright;

namespace Local.Functions
{
    public static class TimerTriggeredFunction
    {
        [FunctionName("TimerTriggeredFunction")]
        public static async Task RunAsync([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, ILogger log)
        {
            
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.UtcNow}");
            // var exitCode = Program.Main(new[] { "install", "--with-deps", "chromium" });
            // if (exitCode != 0)
            // {
            //     throw new Exception($"Playwright exited with code {exitCode}");
            // }
        }
    }
}