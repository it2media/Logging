using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2media.Extensions.Logging.Abstractions.TestNet461
{
    public struct LogMessageEntry
    {
        public string LevelString;
        public ConsoleColor? LevelBackground;
        public ConsoleColor? LevelForeground;
        public ConsoleColor? MessageColor;
        public string Message;
    }
}
