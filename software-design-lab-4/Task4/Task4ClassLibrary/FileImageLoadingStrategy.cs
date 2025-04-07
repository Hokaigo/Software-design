using System.IO;

namespace Task4ClassLibrary
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string src)
        {
            if (File.Exists(src))
                return $"<--image loaded from file {src}-->";
            else
                return $"<--file not found!-->";
        }
    }
}
