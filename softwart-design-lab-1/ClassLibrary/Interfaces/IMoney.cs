namespace ClassLibrary.Interfaces
{
    public interface IMoney
    {
        int Whole { get; }  
        int Fractional { get; }
        string Currency { get; }
        void SetValue(int whole, int fractional);
        void ShowValue();
        IMoney Subtract(IMoney money);
    }
}
