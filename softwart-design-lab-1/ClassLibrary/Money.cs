using ClassLibrary.Interfaces;
using System;

namespace ClassLibrary
{
    public class Money : IMoney
    {
        private int _whole;
        private int _fractional;
        public string Currency { get; set; }

        public int Whole
        {
            get => _whole;
            private set
            {
                if (value < 0) throw new ArgumentException("Whole part can't be a negative number.");
                _whole = value;
            }
        }

        public int Fractional
        {
            get => _fractional;
            private set
            {
                if (value < 0) throw new ArgumentException("Fractional part can't be a negative number.");
                if (value >= 100)
                {
                    _whole += value / 100;
                    _fractional = value % 100;
                }
                else
                    _fractional = value;
            }
        }

        public Money(string currency, int whole = 0, int fractional = 0)
        {
            Currency = currency;
            SetValue(whole, fractional);
        }

        public void SetValue(int whole, int fractional)
        {
            if (whole < 0 || fractional < 0)
                throw new ArgumentException("Sum can't be a negative part.");

            Whole = whole;
            Fractional = fractional;
        }

        public override string ToString() => $"{_whole}.{_fractional:D2} {Currency}";
        public void ShowValue() => Console.WriteLine(ToString());

        public IMoney Subtract(IMoney money)
        {
            if (money == null) throw new ArgumentNullException(nameof(money));
            if (!(money is Money other) || other.Currency != Currency)
                throw new ArgumentException("Impossible to substract other currency.");

            int totalCents = (Whole * 100 + Fractional) - (other.Whole * 100 + other.Fractional);
            if (totalCents < 0) totalCents = 0;

            return new Money(Currency, totalCents / 100, totalCents % 100);
        }

        public override bool Equals(object obj)
        {
            if (obj is Money other)
            {
                return Whole == other.Whole && Fractional == other.Fractional && Currency == other.Currency;
            }
            return false;
        }

        public override int GetHashCode() => (Whole, Fractional, Currency).GetHashCode();


    }
}
