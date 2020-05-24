using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.IO.Abstractions;

namespace AZPackTest
{
    public static class TimerTriggerCSharp1
    {
        [FunctionName("TimerTriggerCSharp1")]
        public static void Run([TimerTrigger("0 */5 * * * *", RunOnStartup=true)]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var fileSystem = new FileSystem();
            var currentDirectory = fileSystem.Directory.GetCurrentDirectory();
        }
    }
}
