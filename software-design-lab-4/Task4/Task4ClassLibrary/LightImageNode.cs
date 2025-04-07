using System;
using Task3ClassLibrary;

namespace Task4ClassLibrary
{
    public class LightImageNode : LightElementNode
    {
        public string Src { get; }
        private IImageLoadingStrategy _strategy;

        public LightImageNode(string src) : base("img", DisplayType.Inline, true)
        {
            Src = src;
            _strategy = src.StartsWith("http", StringComparison.OrdinalIgnoreCase) ? (IImageLoadingStrategy) new InternetImageLoadingStrategy() 
                : new FileImageLoadingStrategy();
        }


        public string LoadImage() => _strategy.LoadImage(Src);

        public override string GetOuterHtml(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 2);
            string style = $"style=\"display: {(Display == DisplayType.Block ? "block" : "inline")};\"";
            return $"{indent}<img src=\"{Src}\" {style}/>\n";
        }
    }
}
