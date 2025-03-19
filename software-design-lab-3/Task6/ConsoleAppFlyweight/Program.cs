using System;
using System.IO;
using ClassLibraryComposite;

namespace ConsoleAppFlyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectRootPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            string pathToRead = Path.Combine(projectRootPath, "books.txt");

            if (!File.Exists(pathToRead))
            {
                Console.WriteLine("File does not exit");
                return;
            }

            string[] lines = File.ReadAllLines(pathToRead);
            FlyweightFactory factory = new FlyweightFactory();
            LightElementNode root = factory.GetElement("div");

            for (int i = 0; i < lines.Length; i++)
            {
                string rawLine = lines[i];
                string line = rawLine.TrimEnd();
                if (string.IsNullOrWhiteSpace(line)) continue;

                LightElementNode element;
                if (i == 0) 
                    element = factory.GetElement("h1");
                else if (line.Length < 20)
                    element = factory.GetElement("h2");
                else if (rawLine.StartsWith(" "))
                    element = factory.GetElement("blockquote");
                else
                    element = factory.GetElement("p");

                element.AddChild(new LightTextNode(line));
                root.AddChild(element);
            }

            long memoryBefore = GC.GetTotalMemory(true);
            string html = root.GetOuterHtml();
            long memoryAfter = GC.GetTotalMemory(false);

            File.WriteAllText("outputBooks.html", html);

            Console.WriteLine($"Memory used: {memoryAfter - memoryBefore} B");
            Console.WriteLine($"Result is in: {Path.Combine(Directory.GetCurrentDirectory(), "outputBooks.html")}");
        }
    }
}
