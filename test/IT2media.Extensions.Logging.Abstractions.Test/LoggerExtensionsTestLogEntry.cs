using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace IT2media.Extensions.Logging.Abstractions.Test
{
    public class LoggerExtensionsTestLogEntry
    {
        private EventId eventId;
        private Exception exception;
        private LogLevel logLevel;
        private object state;

        public LoggerExtensionsTestLogEntry(LogLevel logLevel, EventId eventId, object state, Exception exception)
        {
            this.logLevel = logLevel;
            this.eventId = eventId;
            this.state = state;
            this.exception = exception;
        }
    }
}
