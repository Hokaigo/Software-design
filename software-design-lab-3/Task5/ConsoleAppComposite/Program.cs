using ClassLibraryComposite;
using ClassLibraryComposite.Commands;
using ClassLibraryComposite.enums;
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

            LightElementNode ul = new LightElementNode("ul", DisplayType.Inline, false);
            ul.AddChild(new LightTextNode("Welcome to a home page!"));

            div.AddChild(ul);

            Console.WriteLine("Without rendering ->");
            Console.WriteLine(div.GetOuterHtml());

            div.HandleEvent(InteractionEvent.MouseEnter);
            div.HandleEvent(InteractionEvent.MouseDown);
            div.HandleEvent(InteractionEvent.MouseUp);
            div.HandleEvent(InteractionEvent.MouseLeave);

            Console.WriteLine("\nWith rendering ->");
            Console.WriteLine(div.Render());

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

            Console.WriteLine("\nWith Command Pattern ->");

            CommandManager manager = new CommandManager();

            var enterCommand = new EventCommand(div, InteractionEvent.MouseEnter);
            var downCommand = new EventCommand(div, InteractionEvent.MouseDown);

            manager.Execute(enterCommand); 
            manager.Execute(downCommand); 

            Console.WriteLine($"Current classes after commands: {string.Join(", ", div.CssClasses)}");

            manager.Undo();
            Console.WriteLine($"After undo: {string.Join(", ", div.CssClasses)}");

            manager.Undo(); 
            Console.WriteLine($"After second undo: {string.Join(", ", div.CssClasses)}");

            manager.Redo();
            Console.WriteLine($"After redo: {string.Join(", ", div.CssClasses)}");
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
