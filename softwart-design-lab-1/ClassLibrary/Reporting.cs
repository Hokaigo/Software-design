using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Reporting : IReporting
    {
        private List<string> _accounting;

        public Reporting()
        {
            _accounting = new List<string>();
        }

        public void RecordIn(IProduct product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            if (quantity <= 0)
                throw new ArgumentException("Error: Quantity must be more than 0!");

            _accounting.Add($"{DateTime.Now}: received {product.Name} in quantity of {quantity} {product.Unit}");
        }

        public void RecordOut(IProduct product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            if (quantity <= 0)
                throw new ArgumentException("Error: Quantity must be more than 0!");

            _accounting.Add($"{DateTime.Now}: removed {product.Name} in quantity of {quantity} {product.Unit}");
        }

        public void ShowAccounting()
        {
            foreach (var record in _accounting)
            {
                Console.WriteLine(record + "\n");
            }
        }
    }
}
