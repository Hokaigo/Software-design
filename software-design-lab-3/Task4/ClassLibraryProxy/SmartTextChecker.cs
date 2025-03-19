using System;

public class SmartTextChecker : ISmartTextReader
{
    private readonly ISmartTextReader _reader;

    public SmartTextChecker(ISmartTextReader reader)
    {
        _reader = reader;
    }

    public char[][] ReadFile()
    {
        Console.WriteLine("Opening file...");

        try
        {
            char[][] content = _reader.ReadFile();

            if (content.Length == 0)
            {
                Console.WriteLine("File was not read or is empty.");
                return content;
            }

            Console.WriteLine("Successfully read file.");
            Console.WriteLine($"Total lines: {content.Length}");

            int totalChars = 0;
            foreach (char[] line in content)
            {
                totalChars += line.Length;
            }

            Console.WriteLine($"Total characters: {totalChars}");
            Console.WriteLine("Closing file...");
            return content;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the file.");
            Console.WriteLine($"Error: {ex.Message}");
            return new char[0][];
        }
    }
}
