using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace EddBotFunctions
{
    public class TATAKIOKOSU
    {
        private readonly ILogger _logger;

        public TATAKIOKOSU(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<TATAKIOKOSU>();
        }

        [Function("TATAKIOKOSU")]
        public async Task Run([TimerTrigger("0 */2 * * * *")] MyInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            using(var httpclient = new HttpClient())
            {
                var response = await httpclient.GetAsync(Environment.GetEnvironmentVariable("BASE_URL"));
            }
        }
    }

    public class MyInfo
    {
        public MyScheduleStatus ScheduleStatus { get; set; }

        public bool IsPastDue { get; set; }
    }

    public class MyScheduleStatus
    {
        public DateTime Last { get; set; }

        public DateTime Next { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
