using System;

namespace ClassLibraryComposite
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public LightTextNode(string text) => Text = text;

        public override string GetInnerHtml() => Text;

        public override string GetOuterHtml(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 2);
            return $"{indent}{Text}\n";
        }

        protected override void OnCreated() => Console.WriteLine($"TextNode: \"{Text}\" created");
        protected override void OnInserted() => Console.WriteLine($"TextNode: \"{Text}\" inserted");
        protected override void OnRemoved() => Console.WriteLine($"TextNode: \"{Text}\" removed");
        protected override void OnTextRendered() => Console.WriteLine($"TextNode: \"{Text}\" text rendered");
    }
}
