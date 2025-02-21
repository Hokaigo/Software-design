namespace ClassLibrary.Interfaces
{
    public interface IReporting
    {
        void RecordIn(IProduct product, int quantity);
        void RecordOut(IProduct product, int quantity);
        void ShowAccounting();
    }
}
