using System.Collections.Generic;
using System;
using ClassLibrary.Interfaces;

public class Warehouse : IWarehouse
{
    private Dictionary<IProduct, (int Quantity, DateTime LastDeliveryTime)> _stock;

    public Warehouse()
    {
        _stock = new Dictionary<IProduct, (int, DateTime)>();
    }

    public void Add(IProduct product, int quantity)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        if (quantity <= 0) throw new ArgumentException("Quantity must be more than 0!");

        if (_stock.ContainsKey(product))
            _stock[product] = (_stock[product].Quantity + quantity, DateTime.Now);
        else
            _stock[product] = (quantity, DateTime.Now);
    }

    public void Remove(IProduct product, int quantity)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        if (!_stock.ContainsKey(product) || _stock[product].Quantity < quantity)
            throw new ArgumentException("Insufficient stock!");

        if (_stock[product].Quantity == quantity)
            _stock.Remove(product);
        else
            _stock[product] = (_stock[product].Quantity - quantity, _stock[product].LastDeliveryTime);
    }

    public void ShowInfo()
    {
        foreach (var item in _stock)
        {
            Console.WriteLine($"Product: {item.Key.Name}, Unit: {item.Key.Unit}, Price: {item.Key.Price}, " +
                              $"Quantity: {item.Value.Quantity}, Last Delivery: {item.Value.LastDeliveryTime}");
        }
    }
}

