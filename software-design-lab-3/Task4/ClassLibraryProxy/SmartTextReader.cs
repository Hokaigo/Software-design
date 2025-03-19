using System;
using System.IO;

public class SmartTextReader : ISmartTextReader
{
    public string Path { get; }

    public SmartTextReader(string path)
    {
        Path = path;
    }

    public char[][] ReadFile()
    {
        if (!File.Exists(Path))
        {
            Console.WriteLine("File not found!");
            return new char[0][];
        }

        string[] lines = File.ReadAllLines(Path);
        char[][] result = new char[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            result[i] = lines[i].ToCharArray();
        }

        return result;
    }
}