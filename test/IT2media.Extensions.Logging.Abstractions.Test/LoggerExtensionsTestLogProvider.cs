using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
