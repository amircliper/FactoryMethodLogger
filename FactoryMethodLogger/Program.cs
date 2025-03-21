using FactoryMethodLogger.UI;

namespace FactoryMethodLogger;

/// <summary>
///     The Main program class that serves as the entry point of the application.
/// </summary>
internal class Program
{
    /// <summary>
    ///     The main method where the program execution starts.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    private static void Main(string[] args)
    {
        // Display the console menu to the user
        ConsoleMenu.Show();
    }
}