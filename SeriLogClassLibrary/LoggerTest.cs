using Serilog;

namespace SeriLogClassLibrary
{
    public static class SerilogTest
    {
        public static ILogger GetInstance()
        {
            return new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .WriteTo.File(path: Path.Combine(Environment.CurrentDirectory, "Logs", "log.txt"),
                        rollOnFileSizeLimit: true,
                        retainedFileCountLimit: 20,
                        rollingInterval: RollingInterval.Day,
                        fileSizeLimitBytes: 10000
                    )
                    .CreateLogger();
        }
    }
}