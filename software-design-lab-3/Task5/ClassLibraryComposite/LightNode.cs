using System;

namespace ClassLibraryComposite
{
    public abstract class LightNode
    {
        public string Render(int indentLevel = 0)
        {
            OnCreated();
            OnStylesApplied();
            OnClassListApplied();

            string html = RenderContent(indentLevel);

            OnTextRendered();
            return html;
        }

        protected virtual string RenderContent(int indentLevel) => GetOuterHtml(indentLevel);

        public void NotifyInserted() => OnInserted();
        public void NotifyRemoved() => OnRemoved();

        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }

        public abstract string GetInnerHtml();
        public abstract string GetOuterHtml(int indentLevel = 0);
    }
}
