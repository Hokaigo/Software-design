using ClassLibrary.Interfaces;
using ClassLibrary;
using System;

public class PercentageReduction : IPriceReduction
{
    private double _percentage;

    public PercentageReduction(double percentage)
    {
        if (percentage < 0 || percentage > 100)
            throw new ArgumentException("Percentage must be between 0 and 100!");

        _percentage = percentage;
    }

    public IMoney Reduction(IMoney currentPrice)
    {
        if (currentPrice == null) throw new ArgumentNullException(nameof(currentPrice));

        int totalFractional = currentPrice.Whole * 100 + currentPrice.Fractional;
        int discountFractional = (int)(totalFractional * (_percentage / 100));
        int newTotalCents = totalFractional - discountFractional;
        if (newTotalCents < 0) newTotalCents = 0; 

        return new Money(currentPrice.Currency, newTotalCents / 100, newTotalCents % 100);
    }
}
