using IT2media.Extensions.String;
using Microsoft.Extensions.Logging;
using System;

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
            var hashCode = 0;
            hashCode = GetHashCode(ref message, exception, hashCode);

            if (args == null)
            {
                logger.LogDebug(hashCode, exception, message);
            }
            else
            {
                logger.LogDebug(hashCode, exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogDebug(this ILogger logger, Exception exception, params object[] args)
        {
            var hashCode = 0;
            hashCode = GetHashCodeFromException(exception, hashCode);

            if (args == null)
            {
                logger.LogDebug(hashCode, exception, TryGetMessage(exception));
            }
            else
            {
                logger.LogDebug(hashCode, exception, TryGetMessage(exception), args);
            }
        }

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
            var hashCode = 0;
            hashCode = GetHashCode(ref message, exception, hashCode);

            if (args == null)
            {
                logger.LogTrace(hashCode, exception, message);
            }
            else
            {
                logger.LogTrace(hashCode, exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogTrace(this ILogger logger, Exception exception, params object[] args)
        {
            var hashCode = 0;
            hashCode = GetHashCodeFromException(exception, hashCode);

            if (args == null)
            {
                logger.LogTrace(hashCode, exception, TryGetMessage(exception));
            }
            else
            {
                logger.LogTrace(hashCode, exception, TryGetMessage(exception), args);
            }
        }

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
            var hashCode = 0;
            hashCode = GetHashCode(ref message, exception, hashCode);

            if (args == null)
            {
                logger.LogInformation(hashCode, exception, message);
            }
            else
            {
                logger.LogInformation(hashCode, exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a information log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogInformation(this ILogger logger, Exception exception, params object[] args)
        {
            var hashCode = 0;
            hashCode = GetHashCodeFromException(exception, hashCode);

            if (args == null)
            {
                logger.LogInformation(hashCode, exception, TryGetMessage(exception));
            }
            else
            {
                logger.LogInformation(hashCode, exception, TryGetMessage(exception), args);
            }
        }

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
            var hashCode = 0;
            hashCode = GetHashCode(ref message, exception, hashCode);

            if (args == null)
            {
                logger.LogWarning(hashCode, exception, message);
            }
            else
            {
                logger.LogWarning(hashCode, exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogWarning(this ILogger logger, Exception exception, params object[] args)
        {
            var hashCode = 0;
            hashCode = GetHashCodeFromException(exception, hashCode);

            if (args == null)
            {
                logger.LogWarning(hashCode, exception, TryGetMessage(exception));
            }
            else
            {
                logger.LogWarning(hashCode, exception, TryGetMessage(exception), args);
            }
        }

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
            var hashCode = 0;
            hashCode = GetHashCode(ref message, exception, hashCode);

            if (args == null)
            {
                logger.LogError(hashCode, exception, message);
            }
            else
            {
                logger.LogError(hashCode, exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogError(this ILogger logger, Exception exception, params object[] args)
        {
            var hashCode = 0;
            hashCode = GetHashCodeFromException(exception, hashCode);

            if (args == null)
            {
                logger.LogError(hashCode, exception, TryGetMessage(exception));
            }
            else
            {
                logger.LogError(hashCode, exception, TryGetMessage(exception), args);
            }
        }

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
            var hashCode = 0;
            hashCode = GetHashCode(ref message, exception, hashCode);

            if (args == null)
            {
                logger.LogCritical(hashCode, exception, message);
            }
            else
            {
                logger.LogCritical(hashCode, exception, message, args);
            }
        }

        /// <summary>
        /// Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogCritical(this ILogger logger, Exception exception, params object[] args)
        {
            var hashCode = 0;
            hashCode = GetHashCodeFromException(exception, hashCode);

            if (args == null)
            {
                logger.LogCritical(hashCode, exception, TryGetMessage(exception));
            }
            else
            {
                logger.LogCritical(hashCode, exception, TryGetMessage(exception), args);
            }
        }

        #region GetHashCodes

        /// <summary>
        /// Returns an ushort hash based on the message, if message is null the exception's message is taken
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="defaultHashCode"></param>
        /// <returns></returns>
        private static int GetHashCode(ref string message, Exception exception, int defaultHashCode)
        {
            if (message == null)
            {
                message = string.Empty;
                defaultHashCode = GetHashCodeFromException(exception, defaultHashCode);
            }
            else
            {
                defaultHashCode = message.GetHashCodeUShort();
            }

            return defaultHashCode;
        }

        /// <summary>
        /// Returns an ushort hash based on the exception's message
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="defaultHashCode"></param>
        /// <returns></returns>
        private static int GetHashCodeFromException(Exception exception, int defaultHashCode)
        {
            if (exception != null && exception.Message != null) //currently this is not the case, but with different .NET Frameworks and Mono-Implementations we can't be sure, so let's do this safe
            {
                defaultHashCode = exception.Message.GetHashCodeUShort();
            }

            return defaultHashCode;
        }

        #endregion
        
        private static string TryGetMessage(Exception exception)
        {
            return exception?.Message ?? string.Empty;
        }
    }
}
