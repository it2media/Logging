using Microsoft.Extensions.Logging;

namespace IT2media.Extensions.Logging.Abstractions.Test
{
    public class LoggerExtensionsTestLogProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new LoggerExtensionsTestLogger();
        }

        public void Dispose()
        {
            
        }
    }
}
