using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using IT2media.Extensions.Logging.Abstractions;
using Xunit;

namespace IT2media.Extensions.Logging.Abstractions.Test
{
    public class LoggerExtensionsTest
    {
        private readonly ILogger _logger;
        private readonly ILoggerFactory _loggerFactory;

        public LoggerExtensionsTest()
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new LoggerExtensionsTestLogProvider());

            _loggerFactory = loggerFactory;
            _logger = loggerFactory.CreateLogger<LoggerExtensionsTest>();
        }

        [Fact]
        public void ExceptionyOnlyTests()
        {
            int countBefore = LoggerExtensionsTestLogger.LogEntries.Count;

            Exception exMessageNull = new Exception(null);
            _logger.LogDebug(exMessageNull);

            Exception exMessageNotNull = new Exception("test");
            _logger.LogDebug(exMessageNotNull);

            //ExceptionyOnlyTests*
            object o = null;
            _logger.LogDebug(exMessageNull, o);

            //ExceptionyOnlyTests*
            string s = null;
            _logger.LogDebug(exMessageNull, s);

            _logger.LogDebug(exMessageNull, s, null); //args = null

            _logger.LogDebug(exMessageNull, s, null, null);

            string s2 = "test";
            object o2 = new object();

            _logger.LogDebug(exMessageNull, s2);
            _logger.LogDebug(exMessageNull, s2, o2);
            
            int countAfter = LoggerExtensionsTestLogger.LogEntries.Count;

            Assert.True(countAfter == countBefore + 8);
        }

        [Fact]
        public void NullTests()
        {
            int countBefore = LoggerExtensionsTestLogger.LogEntries.Count;

            _logger.LogDebug(null);
            //_logger.LogDebug(null, null); //ambigous call => see ExceptionyOnlyTests*
            _logger.LogDebug(null, null, null);
            _logger.LogDebug(null, null, null, null);

            int countAfter = LoggerExtensionsTestLogger.LogEntries.Count;
            Assert.True(countAfter == countBefore + 3);
        }
    }
}
