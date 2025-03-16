namespace ClassLibraryComposite
{
    public abstract class LightNode
    {
        public abstract string GetInnerHtml();
        public abstract string GetOuterHtml(int indentLevel = 0);
    }
}
