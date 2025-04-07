namespace Task1ClassLibrary
{
    public abstract class Handler
    {
        private Handler next;

        public Handler SetNextHandler(Handler next)
        {
            this.next = next;
            return next;
        }

        public abstract bool Handle(SupportedRequestType request);

        protected bool HandleNext(SupportedRequestType request)
        {
            if (next != null)
                return next.Handle(request);
            else
                return false;
        }
    }
}
