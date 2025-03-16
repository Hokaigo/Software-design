using System.IO;

namespace ClassLibraryAdapter
{
    public class FileWriter
    {
        private string _path;
        public FileWriter(string path) 
        { 
            _path = path;

            string directory = Path.GetDirectoryName(_path) ?? "";
            if (directory != "" && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        public void Write(string txt)
        {
            using (StreamWriter sw = new StreamWriter(_path, append: true))
            {
                sw.Write(txt);
            }
        }

        public void WriteLine(string txt)
        {
            using (StreamWriter sw = new StreamWriter(_path, append: true))
            {
                sw.WriteLine(txt);
            }
        }
    }
}
