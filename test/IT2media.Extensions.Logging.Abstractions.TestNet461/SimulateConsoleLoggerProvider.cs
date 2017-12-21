using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2media.Extensions.Logging.Abstractions.TestNet461
{
    public class SimulateConsoleLoggerProvider : ILoggerProvider
    {
        public void Dispose()
        {
            
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new SimulateConsoleLogger();
        }
    }
}
