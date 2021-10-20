using System;

namespace D
{
    public class DatabaseLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of DatabaseLogger.");
            LogToDatabase(message);
        }
        private void LogToDatabase(string message) => Console.WriteLine($"Method: LogToDatabase, Text: {message}");
    }

    public class FileLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger.");
            LogToFile(message);
        }
        private void LogToFile(string message) => Console.WriteLine($"Method: LogToFile, Text: {message}");
    }

    public class ProductService
    {
        private readonly FileLogger _fileLogger = new();
        public void LogToFile(string message)
        {
            _fileLogger.Log(message);
        }
    }
}
