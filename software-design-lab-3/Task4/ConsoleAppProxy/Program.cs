using System.IO;

class Program
{
    static void Main()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "logs", "logs.txt");
        string filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "logs", "testLog.txt");
        string pattern = @".*testLog.*";


        ISmartTextReader reader = new SmartTextReader(filePath);

        ISmartTextReader checker = new SmartTextChecker(reader);

        ISmartTextReader locker = new SmartTextReaderLocker(reader, filePath2, pattern);

        checker.ReadFile();

        locker.ReadFile();
    }
}
