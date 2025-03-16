using System;

namespace ClassLibraryAdapter
{
    public class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Message: " + msg);
            Console.ResetColor();
        }

        public void Error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + msg);
            Console.ResetColor();
        }
        public void Warn(string msg)
        { 
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("Warning: " + msg);
            Console.ResetColor();
        }

    }
}
