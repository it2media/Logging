using System;
using Microsoft.Extensions.Logging;
using Xunit;

namespace IT2media.Extensions.Logging.Abstractions.TestNet461
{
    public class LoggerExtensionsTest : TestBase.LoggerExtensionsTest
    {
        [Fact]
        public void EnsureExceptionMessageIsLogged()
        {
            var loggerFactory = new LoggerFactory();

            loggerFactory.AddProvider(new SimulateConsoleLoggerProvider());

            ILogger logger = loggerFactory.CreateLogger<LoggerExtensionsTest>();

            logger.LogError(new Exception("TestMessage"));
        }
    }
}
