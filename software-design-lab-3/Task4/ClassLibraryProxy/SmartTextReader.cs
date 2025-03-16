using System.IO;

public class SmartTextReader : ISmartTextReader
{
    private string _path;

    public SmartTextReader(string path)
    {
        _path = path;
    }

    public char[][] ReadFile()
    {
        string[] lines = File.ReadAllLines(_path);
        char[][] result = new char[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            result[i] = lines[i].ToCharArray();
        }

        return result;
    }
}
