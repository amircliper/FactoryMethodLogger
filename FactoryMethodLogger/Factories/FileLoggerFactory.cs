using FactoryMethodLogger.Loggers;

namespace FactoryMethodLogger.Factories;

/// <summary>
///     Factory class for creating instances of FileLogger.
///     Implements ILoggerFactory to adhere to factory design pattern.
/// </summary>
public class FileLoggerFactory : ILoggerFactory
{
    /// <summary>
    ///     Creates a new instance of FileLogger.
    /// </summary>
    /// <returns>An instance of ILogger.</returns>
    public ILogger CreateLogger()
    {
        return new FileLogger();
    }
}