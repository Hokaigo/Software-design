namespace Task4ClassLibrary
{
    public class InternetImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string src)
        {
            if (src.StartsWith("http"))
                return $"<--image loaded from the internet {src}-->";
            else
                return $"<--image doesn't exist for this url-->";
        }
    }
}
