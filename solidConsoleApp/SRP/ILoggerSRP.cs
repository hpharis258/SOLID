using System;
namespace solidConsoleApp
{
    public interface ILogger
    {
        void LogError(string message, Exception ex);
    }
}