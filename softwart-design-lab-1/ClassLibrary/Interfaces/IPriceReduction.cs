namespace ClassLibrary.Interfaces
{
    public interface IPriceReduction
    {
        IMoney Reduction(IMoney currentPrice);
    }
}
