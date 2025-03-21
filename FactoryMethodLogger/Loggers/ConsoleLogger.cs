namespace FactoryMethodLogger.Loggers;

/// <summary>
///     A logger that writes log messages to the console.
///     Implements the ILogger interface.
/// </summary>
public class ConsoleLogger : ILogger
{
    /// <summary>
    ///     Logs a message to the console with a specific format.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Log(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            throw new ArgumentException("Message cannot be null or empty.", nameof(message));

        Console.WriteLine($"[Console] {message}");
    }
}