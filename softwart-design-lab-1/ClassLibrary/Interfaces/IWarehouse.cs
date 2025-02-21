namespace ClassLibrary.Interfaces
{
    public interface IWarehouse
    {
        void Add(IProduct product, int quantity);
        void Remove(IProduct product, int quantity);
        void ShowInfo();
    }
}
