using FactoryMethodLogger.Loggers;

namespace FactoryMethodLogger.Factories;

public interface ILoggerFactory
{
    ILogger CreateLogger();
}