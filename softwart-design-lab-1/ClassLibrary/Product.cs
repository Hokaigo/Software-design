using ClassLibrary.Interfaces;
using System;

public class Product : IProduct
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public IMoney Price { get; private set; }

    public Product(string name, string unit, IMoney price)
    {
        Name = name;
        Unit = unit;
        Price = price ?? throw new ArgumentNullException(nameof(price));
    }

    public void ReducePrice(IPriceReduction strategy)
    {
        if (strategy == null) throw new ArgumentNullException(nameof(strategy));
        Price = strategy.Reduction(Price);
    }

    public override bool Equals(object obj)
    {
        if (obj is Product other)
        {
            return Name == other.Name && Unit == other.Unit && Price.Currency == other.Price.Currency;
        }
        return false;
    }

    public override int GetHashCode() => (Name, Unit, Price.Currency).GetHashCode();

}
