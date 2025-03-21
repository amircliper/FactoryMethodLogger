using FactoryMethodLogger.Factories;
using FactoryMethodLogger.Services;

namespace FactoryMethodLogger.UI;

public class ConsoleMenu
{
    /// <summary>
    ///     Displays the logging method selection menu and handles user input.
    /// </summary>
    public static void Show()
    {
        while (true)
        {
            DisplayMenu();
            var userChoice = GetUserChoice();

            if (!TryGetLoggerFactory(userChoice, out var loggerFactory)) break; // Exit if the user chooses to exit

            if (loggerFactory != null) LogMessage(loggerFactory);
        }
    }

    /// <summary>
    ///     Displays the logging methods menu options to the console.
    /// </summary>
    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("📌 Select Logging Method:");
        Console.WriteLine("1️⃣ File Logger");
        Console.WriteLine("2️⃣ Database Logger");
        Console.WriteLine("3️⃣ Console Logger");
        Console.WriteLine("0️⃣ Exit");
        Console.Write("👉 Choose an option: ");
    }

    /// <summary>
    ///     Gets the user's choice from the console input.
    /// </summary>
    /// <returns>The user's choice as a string.</returns>
    private static string? GetUserChoice()
    {
        return Console.ReadLine();
    }

    /// <summary>
    ///     Tries to get the appropriate logger factory based on user selection.
    /// </summary>
    /// <param name="choice">The user selection.</param>
    /// <param name="loggerFactory">Output parameter for the selected logger factory.</param>
    /// <returns>True if a valid factory was created, otherwise false.</returns>
    private static bool TryGetLoggerFactory(string? choice, out ILoggerFactory? loggerFactory)
    {
        loggerFactory = choice switch
        {
            "1" => new FileLoggerFactory(),
            "2" => new DatabaseLoggerFactory(),
            "3" => new ConsoleLoggerFactory(),
            "0" => null,
            _ => throw new ArgumentException("Invalid selection!")
        };

        return loggerFactory != null;
    }

    /// <summary>
    ///     Logs a message using the specified logger factory.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    private static void LogMessage(ILoggerFactory loggerFactory)
    {
        var loggerService = new LoggerService(loggerFactory);
        Console.Write("\n✍ Enter log message: ");
        var message = Console.ReadLine() ?? string.Empty;
        loggerService.LogMessage(message);

        Console.WriteLine("\n✅ Log added! Press any key to continue...");
        Console.ReadKey();
    }
}