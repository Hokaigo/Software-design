using ClassLibrary.Interfaces;

public interface IProduct
{
    string Name { get; }
    string Unit { get; }
    IMoney Price { get; }
    void ReducePrice(IPriceReduction strategy);
}
