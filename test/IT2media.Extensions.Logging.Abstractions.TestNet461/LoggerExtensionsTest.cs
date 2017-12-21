using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT2media.Extensions.Logging.Abstractions.TestBase;
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

            ILogger _logger = loggerFactory.CreateLogger<LoggerExtensionsTest>();

            _logger.LogError(new Exception("TestMessage"));
        }
    }
}
