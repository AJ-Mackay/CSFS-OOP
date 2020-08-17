using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var newWarehouse = new Warehouse("Warehouse 1", 101);
            var myItem = newWarehouse.FindAndReturnItem(101);
            Console.WriteLine("My new item is " + myItem.Name);
        }
    }
}