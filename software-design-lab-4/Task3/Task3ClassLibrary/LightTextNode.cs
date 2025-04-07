namespace Task3ClassLibrary
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
    }
}
