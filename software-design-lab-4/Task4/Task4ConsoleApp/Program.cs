using System;
using System.IO;
using Task3ClassLibrary;
using Task4ClassLibrary;

namespace Task4ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectRootPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            string imgPath = Path.Combine(projectRootPath, "brick.jpg");

            var div = new LightElementNode("div", DisplayType.Block, false);

            var fileImg = new LightImageNode(imgPath);
            Console.WriteLine(fileImg.LoadImage());
            div.AddChild(fileImg);

            var internetImg = new LightImageNode("https://unsplash.com/photos/a-pile-of-bricks-stacked-on-top-of-each-other-sKfxpU49eNg");
            Console.WriteLine(internetImg.LoadImage() + "\n");
            div.AddChild(internetImg);

            Console.WriteLine(div.GetOuterHtml());
        }
    }
}
