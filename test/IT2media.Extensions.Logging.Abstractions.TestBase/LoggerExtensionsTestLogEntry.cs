using System;
using Microsoft.Extensions.Logging;

namespace IT2media.Extensions.Logging.Abstractions.TestBase
{
    public class LoggerExtensionsTestLogEntry
    {
        public EventId Id { get; }
        public Exception Exception { get; }
        public LogLevel Level { get; }
        public object State { get; }

        public LoggerExtensionsTestLogEntry(LogLevel logLevel, EventId eventId, object state, Exception exception)
        {
            Level = logLevel;
            Id = eventId;
            State = state;
            Exception = exception;
        }
    }
}
