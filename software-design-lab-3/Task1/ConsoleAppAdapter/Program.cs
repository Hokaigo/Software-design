using ClassLibraryAdapter;
using System;
using System.IO;

namespace ConsoleAppAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log("Some message");
            logger.Error("Error message");
            logger.Warn("Warn message");

            string logsPath = Path.Combine(Directory.GetCurrentDirectory(), "logs", "logs.txt");
            Console.WriteLine(logsPath);

            FileLogger fileLogger = new FileLogger(logsPath);

            try
            {
                fileLogger.Log("Some message");
                fileLogger.Error("Error message");
                fileLogger.Warn("Warn message");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}
