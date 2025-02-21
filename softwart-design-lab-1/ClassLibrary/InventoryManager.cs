using ClassLibrary.Interfaces;
using System;

namespace ClassLibrary
{
    public class InventoryManager
    {
        private IWarehouse _warehouse;
        private IReporting _reporting;

        public InventoryManager(IWarehouse warehouse, IReporting reporting)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
            _reporting = reporting ?? throw new ArgumentNullException(nameof(reporting));
        }

        public void AddProduct(IProduct product, int quantity)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentException("Quantity must be more than 0!");

            _warehouse.Add(product, quantity);
            _reporting.RecordIn(product, quantity);
        }

        public void RemoveProduct(IProduct product, int quantity)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentException("Quantity must be more than 0!");

            _warehouse.Remove(product, quantity);
            _reporting.RecordOut(product, quantity);
        }

        public void ShowInventoryInfo()
        {
            _warehouse.ShowInfo();
        }

        public void ShowAccountingInfo()
        {
            _reporting.ShowAccounting();
        }
    }
}
