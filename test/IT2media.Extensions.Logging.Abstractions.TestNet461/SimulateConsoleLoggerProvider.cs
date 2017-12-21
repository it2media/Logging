using Microsoft.Extensions.Logging;

namespace IT2media.Extensions.Logging.Abstractions.TestNet461
{
    public class SimulateConsoleLoggerProvider : ILoggerProvider
    {
        public void Dispose()
        {
            
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new SimulateConsoleLogger();
        }
    }
}
