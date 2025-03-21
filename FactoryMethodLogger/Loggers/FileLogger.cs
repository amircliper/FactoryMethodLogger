namespace FactoryMethodLogger.Loggers;

public class FileLogger : ILogger
{
    private const string LogFilePath = "logs.txt";

    /// <summary>
    ///     Logs a message to a file with a timestamp.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Log(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            throw new ArgumentException("Log message cannot be null or empty.", nameof(message));

        AppendLogMessageToFile(message);
        Console.WriteLine("Log saved to file.");
    }

    /// <summary>
    ///     Appends the log message to the specified log file.
    /// </summary>
    /// <param name="message">The message to append.</param>
    private void AppendLogMessageToFile(string message)
    {
        var logEntry = $"{DateTime.Now}: {message}{Environment.NewLine}";
        File.AppendAllText(LogFilePath, logEntry);
    }
}