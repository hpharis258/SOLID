using solidConsoleApp;

public class FileLogger : ILogger
{
    public void LogError(string message, Exception ex)
    {
        using (StreamWriter writer = new StreamWriter("error_log.txt", true))
        {
            writer.WriteLine($"Error: {message}, Exception: {ex.Message}");
        }
    }
}