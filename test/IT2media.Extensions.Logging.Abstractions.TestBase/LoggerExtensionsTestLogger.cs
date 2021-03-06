﻿using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace IT2media.Extensions.Logging.Abstractions.TestBase
{
    public class LoggerExtensionsTestLogger : ILogger
    {
        public static List<LoggerExtensionsTestLogEntry> LogEntries { get; set; } = new List<LoggerExtensionsTestLogEntry>();

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var testLogEntry = new LoggerExtensionsTestLogEntry(logLevel, eventId, state, exception);

            LogEntries.Add(testLogEntry);
        }
    }
}
