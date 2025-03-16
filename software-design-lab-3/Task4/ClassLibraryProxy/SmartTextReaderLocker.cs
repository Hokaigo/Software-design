using System.Text.RegularExpressions;
using System;

public class SmartTextReaderLocker : ISmartTextReader
{
    private ISmartTextReader _reader;
    private Regex _reg;
    private string _path;

    public SmartTextReaderLocker(ISmartTextReader reader, string path, string pattern)
    {
        _reader = reader;
        _path = path;

        try
        {
            _reg = new Regex(pattern, RegexOptions.IgnoreCase);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Incorrect regex pattern: {ex.Message}");
            _reg = null;
        }
    }

    public char[][] ReadFile()
    {
        if (_reg == null)
        {
            Console.WriteLine("Regex is invalid. Allowing file read.");
            return _reader.ReadFile();
        }

        if (_reg.IsMatch(_path))
        {
            Console.WriteLine("Access denied!");
            return new char[0][];
        }

        return _reader.ReadFile();
    }
}
