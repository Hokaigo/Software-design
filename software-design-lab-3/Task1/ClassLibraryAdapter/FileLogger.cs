namespace ClassLibraryAdapter
{
    public class FileLogger : ILogger
    {
        private FileWriter _fileWriter;

        public FileLogger(string path) 
        { 
            _fileWriter = new FileWriter(path);
        }

        public void Error(string msg)
        {
            _fileWriter.WriteLine("Error: " + msg);
        }

        public void Log(string msg)
        {
            _fileWriter.WriteLine("Message: " +msg);
        }

        public void Warn(string msg)
        {
            _fileWriter.WriteLine($"Warning: " + msg);
        }
    }
}
