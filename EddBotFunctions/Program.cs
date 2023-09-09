using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.WebSocket;

namespace EddBotFunctions;


internal class Program
{
    private static void Main()
    {
        var host = new HostBuilder()
            .ConfigureFunctionsWorkerDefaults()
            .Build();

        host.Run();
    }
}
