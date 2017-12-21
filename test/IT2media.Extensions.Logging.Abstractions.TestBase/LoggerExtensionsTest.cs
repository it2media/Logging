using System;
using Microsoft.Extensions.Logging;
using Xunit;

namespace IT2media.Extensions.Logging.Abstractions.TestBase
{
    public class LoggerExtensionsTest
    {
        private const string NotNullTestString = "test";

        private readonly object _notNullTestObject = new object();

        private readonly Exception _testExceptionWithNullMessage = new Exception(null);

        private readonly Exception _testExceptionWithNotNullMessage = new Exception(NotNullTestString);

        private readonly ILogger _logger;

        public LoggerExtensionsTest()
        {
            var loggerFactory = new LoggerFactory();

            loggerFactory.AddProvider(new LoggerExtensionsTestLogProvider());

            _logger = loggerFactory.CreateLogger<LoggerExtensionsTest>();
        }

        [Fact]
        public void ExceptionyOnlyTests()
        {
            var countBefore = LoggerExtensionsTestLogger.LogEntries.Count;

            _logger.LogDebug(_testExceptionWithNullMessage);
            
            _logger.LogDebug(_testExceptionWithNotNullMessage);
            
            _logger.LogDebug(_testExceptionWithNullMessage, (object) null);
            
            _logger.LogDebug(_testExceptionWithNullMessage, (string) null);

            _logger.LogDebug(_testExceptionWithNullMessage, null, null); //args = null

            _logger.LogDebug(_testExceptionWithNullMessage, null, null, null);

            _logger.LogDebug(_testExceptionWithNullMessage, NotNullTestString);

            _logger.LogDebug(_testExceptionWithNullMessage, NotNullTestString, _notNullTestObject);
            
            var countAfter = LoggerExtensionsTestLogger.LogEntries.Count;

            Assert.True(countAfter == countBefore + 8);
        }

        [Fact]
        public void NullTests()
        {
            var countBefore = LoggerExtensionsTestLogger.LogEntries.Count;

            _logger.LogDebug(null);
            //_logger.LogDebug(null, null); //ambigous call => see ExceptionyOnlyTests*
            _logger.LogDebug(null, null, null);
            _logger.LogDebug(null, null, null, null);

            var countAfter = LoggerExtensionsTestLogger.LogEntries.Count;

            Assert.True(countAfter == countBefore + 3);
        }
    }
}
