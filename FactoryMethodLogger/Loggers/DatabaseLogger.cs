namespace FactoryMethodLogger.Loggers;

/// <summary>
///     Represents a logger that stores log messages in a database.
///     Implements the ILogger interface to provide logging functionality.
/// </summary>
public class DatabaseLogger : ILogger
{
    /// <summary>
    ///     Logs a message to the console indicating that it has been stored in the database.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Log(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            throw new ArgumentException("Log message cannot be null or empty.", nameof(message));

        Console.WriteLine($"[Database] Log stored: {message}");
    }
}