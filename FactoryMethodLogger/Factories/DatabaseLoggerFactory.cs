using FactoryMethodLogger.Loggers;

namespace FactoryMethodLogger.Factories;

/// <summary>
///     Factory class responsible for creating instances of DatabaseLogger.
///     Implements the ILoggerFactory interface.
/// </summary>
public class DatabaseLoggerFactory : ILoggerFactory
{
    /// <summary>
    ///     Creates a new instance of DatabaseLogger.
    /// </summary>
    /// <returns>An instance of ILogger.</returns>
    public ILogger CreateLogger()
    {
        return new DatabaseLogger();
    }
}