using ClassLibraryComposite;
using System;

namespace ConsoleAppComposite
{
    internal class Program
    {
        static void Main()
        {
            LightElementNode div = new LightElementNode("div", DisplayType.Block, false);
            div.AddClass("container");

            LightElementNode h1 = new LightElementNode("h1", DisplayType.Block, false);
            h1.AddChild(new LightTextNode("My LightHTML!"));
            div.AddChild(h1);

            LightElementNode p = new LightElementNode("ul", DisplayType.Inline, false);
            p.AddChild(new LightTextNode("Welcome to a home page!"));

            div.AddChild(p);

            Console.WriteLine(div.GetOuterHtml());

            Console.WriteLine("Depth-first ->");
            foreach (var node in div.DepthFirst())
            {
                PrintNode(node);
            }

            Console.WriteLine("\nBreadth-first ->");
            foreach (var node in div.BreadthFirst())
            {
                PrintNode(node);
            }

        }

        static void PrintNode(LightNode node)
        {
            if (node is LightTextNode textNode)
                Console.WriteLine($"{textNode.Text}");
            else if (node is LightElementNode elementNode)
                Console.WriteLine($"<{elementNode.TagName}>");
        }

    }
}
