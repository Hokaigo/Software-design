using ClassLibrary;
using ClassLibrary.Interfaces;
using ClassLibrary.PriceReductionStrategies;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                IWarehouse warehouse = new Warehouse();
                IReporting reporting = new Reporting();
                InventoryManager manager = new InventoryManager(warehouse, reporting);

                IMoney price1 = new Money("USD", 10, 50);
                IProduct product1 = new Product("Apple", "kg", price1);
                IMoney price2 = new Money("USD", 5, 75);
                IProduct product2 = new Product("Banana", "kg", price2);

                manager.AddProduct(product1, 20);
                manager.AddProduct(product2, 15);

                Console.WriteLine("Warehouse:");
                manager.ShowInventoryInfo();

                IPriceReduction straightReduction = new StraightReduction(new Money("USD", 2, 0));
                product1.ReducePrice(straightReduction);

                IPriceReduction percentageReduction = new PercentageReduction(10);
                product2.ReducePrice(percentageReduction);

                Console.WriteLine("\nWarehouse after price reduction:");
                manager.ShowInventoryInfo();

                manager.RemoveProduct(product1, 5);
                manager.RemoveProduct(product2, 10);

                Console.WriteLine("\nWarehouse after removing:");
                manager.ShowInventoryInfo();

                Console.WriteLine("\nAccounting records:");
                manager.ShowAccountingInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
