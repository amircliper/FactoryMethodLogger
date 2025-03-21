using FactoryMethodLogger.Loggers;

namespace FactoryMethodLogger.Factories;

/// <summary>
/// Factory class for creating instances of ConsoleLogger.
/// Implements the ILoggerFactory interface.
/// </summary>
public class ConsoleLoggerFactory : ILoggerFactory
{
    /// <summary>
    /// Creates and returns a new instance of ConsoleLogger.
    /// </summary>
    /// <returns>An instance of ILogger.</returns>
    public ILogger CreateLogger()
    {
        return new ConsoleLogger();
    }
}