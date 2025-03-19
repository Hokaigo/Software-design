using System.Text.RegularExpressions;
using System;

public class SmartTextReaderLocker : ISmartTextReader
{
    private readonly ISmartTextReader _reader;
    private readonly Regex _regex;

    public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
    {
        _reader = reader;

        try
        {
            _regex = new Regex(pattern, RegexOptions.IgnoreCase);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Incorrect regex pattern: {ex.Message}");
            _regex = new Regex(".*", RegexOptions.IgnoreCase);
        }
    }

    public char[][] ReadFile()
    {
        if (_reader is SmartTextReader smartReader)
        {
            Console.WriteLine($"Checking access for file: {smartReader.Path}");

            if (_regex.IsMatch(smartReader.Path))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }
        }

        return _reader.ReadFile();
    }
}
