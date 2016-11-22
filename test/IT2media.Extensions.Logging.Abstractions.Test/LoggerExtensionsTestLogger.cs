using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT2media.Extensions.Logging.Abstractions.Test
{
    public class LoggerExtensionsTestLogger : ILogger
    {
        public static List<LoggerExtensionsTestLogEntry> LogEntries { get; set; } = new List<LoggerExtensionsTestLogEntry>();

        public IDisposable BeginScope<TState>(TState state)
        {
            //throw new NotImplementedException();
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            LoggerExtensionsTestLogEntry testLogEntry = new LoggerExtensionsTestLogEntry(logLevel, eventId, state, exception);

            LogEntries.Add(testLogEntry);
        }
    }
}
