namespace ClassLibraryAdapter
{
    public interface ILogger
    {
        void Log(string msg);
        void Error(string msg);
        void Warn(string msg);
    }
}
