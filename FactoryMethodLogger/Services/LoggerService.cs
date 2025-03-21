using FactoryMethodLogger.Factories;
using FactoryMethodLogger.Loggers;

namespace FactoryMethodLogger.Services;

/// <summary>
///     A service for logging messages.
/// </summary>
public class LoggerService
{
    private readonly ILogger _logger;

    /// <summary>
    ///     Initializes a new instance of the <see cref="LoggerService" /> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory used to create the logger.</param>
    public LoggerService(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger();
    }

    /// <summary>
    ///     Logs a message at the default log level.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void LogMessage(string message)
    {
        _logger.Log(message);
    }
}