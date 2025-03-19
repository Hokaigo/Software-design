using System.IO;
using System;

class Program
{
    static void Main()
    {
        string projectRootPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
        string filePath1 = Path.Combine(projectRootPath, "logs", "logs.txt");
        string filePath2 = Path.Combine(projectRootPath, "logs", "testLog.txt");
        string pattern = @".*testLog.*";

        Console.WriteLine("Disallowed");
        ISmartTextReader reader1 = new SmartTextReader(filePath2);
        ISmartTextReader locker1 = new SmartTextReaderLocker(reader1, pattern);
        ISmartTextReader checker1 = new SmartTextChecker(locker1);
        checker1.ReadFile();  

        Console.WriteLine("\nAllowed:");
        ISmartTextReader reader2 = new SmartTextReader(filePath1);
        ISmartTextReader locker2 = new SmartTextReaderLocker(reader2, pattern);
        ISmartTextReader checker2 = new SmartTextChecker(locker2);
        checker2.ReadFile();  
    }
}
