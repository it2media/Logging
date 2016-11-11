using IT2media.Extensions.String;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT2media.Extensions.Logging.Abstractions
{
    /// <summary>
    /// ILogger extension methods for common scenarios.
    /// </summary>
    public static class LoggerExtensions
    {
        /// <summary>
        /// Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogDebug(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (message == null)
            {
                logger.LogDebug(0, exception, string.Empty, args);
            }
            else
            {
                logger.LogDebug(message.GetHashCodeUShort(), exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        //public static void LogDebug(this ILogger logger, string message, params object[] args)
        //{
        //    if (message == null)
        //    {
        //        logger.LogDebug(0, string.Empty, args);
        //    }
        //    else
        //    {
        //        logger.LogDebug(message.GetHashCodeUShort(), message, args);
        //    }
        //}

        //------------------------------------------TRACE------------------------------------------//

        /// <summary>
        /// Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogTrace(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (message == null)
            {
                logger.LogTrace(0, exception, string.Empty, args);
            }
            else
            {
                logger.LogTrace(message.GetHashCodeUShort(), exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        //public static void LogTrace(this ILogger logger, string message, params object[] args)
        //{
        //    if (message == null)
        //    {
        //        logger.LogTrace(0, string.Empty, args);
        //    }
        //    else
        //    {
        //        logger.LogTrace(message.GetHashCodeUShort(), message, args);
        //    }
        //}

        //------------------------------------------INFORMATION------------------------------------------//

        /// <summary>
        /// Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogInformation(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (message == null)
            {
                logger.LogInformation(0, exception, string.Empty, args);
            }
            else
            {
                logger.LogInformation(message.GetHashCodeUShort(), exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        //public static void LogInformation(this ILogger logger, string message, params object[] args)
        //{
        //    if (message == null)
        //    {
        //        logger.LogInformation(0, string.Empty, args);
        //    }
        //    else
        //    {
        //        logger.LogInformation(message.GetHashCodeUShort(), message, args);
        //    }
        //}

        //------------------------------------------WARNING------------------------------------------//

        /// <summary>
        /// Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogWarning(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (message == null)
            {
                logger.LogWarning(0, exception, string.Empty, args);
            }
            else
            {
                logger.LogWarning(message.GetHashCodeUShort(), exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        //public static void LogWarning(this ILogger logger, string message, params object[] args)
        //{
        //    if (message == null)
        //    {
        //        logger.LogWarning(0, string.Empty, args);
        //    }
        //    else
        //    {
        //        logger.LogWarning(message.GetHashCodeUShort(), message, args);
        //    }
        //}

        //------------------------------------------ERROR------------------------------------------//

        /// <summary>
        /// Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogError(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (message == null)
            {
                logger.LogError(0, exception, string.Empty, args);
            }
            else
            {
                logger.LogError(message.GetHashCodeUShort(), exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        //public static void LogError(this ILogger logger, string message, params object[] args)
        //{
        //    if (message == null)
        //    {
        //        logger.LogError(0, string.Empty, args);
        //    }
        //    else
        //    {
        //        logger.LogError(message.GetHashCodeUShort(), message, args);
        //    }
        //}

        //------------------------------------------CRITICAL------------------------------------------//

        /// <summary>
        /// Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogCritical(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (message == null)
            {
                logger.LogCritical(0, exception, string.Empty, args);
            }
            else
            {
                logger.LogCritical(message.GetHashCodeUShort(), exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        //public static void LogCritical(this ILogger logger, string message, params object[] args)
        //{
        //    if (message == null)
        //    {
        //        logger.LogCritical(0, string.Empty, args);
        //    }
        //    else
        //    {
        //        logger.LogCritical(message.GetHashCodeUShort(), message, args);
        //    }
        //}
    }
}
