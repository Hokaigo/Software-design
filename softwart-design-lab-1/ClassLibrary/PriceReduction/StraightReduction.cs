using ClassLibrary.Interfaces;
using System;

namespace ClassLibrary.PriceReductionStrategies
{
    public class StraightReduction : IPriceReduction
    {
        private IMoney _reductionAmount;

        public StraightReduction(IMoney reductionAmount)
        {
            _reductionAmount = reductionAmount ?? throw new ArgumentNullException(nameof(reductionAmount));
        }

        public IMoney Reduction(IMoney currentPrice)
        {
            var newPrice = currentPrice.Subtract(_reductionAmount);
            if (newPrice.Whole < 0 || (newPrice.Whole == 0 && newPrice.Fractional < 0))
                return new Money(currentPrice.Currency, 0, 0);
            return newPrice;
        }

    }
}
