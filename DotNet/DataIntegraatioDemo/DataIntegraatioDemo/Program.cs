using System;

namespace DataIntegraatioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloitetaan asiakasdatan kopiointi.");

            DataModelNorthwind.NorthwindContext northwind =
                new DataModelNorthwind.NorthwindContext();

            DataModelAdventureWorks.AdventureWorks2016CTP3Context adventure =
                new DataModelAdventureWorks.AdventureWorks2016CTP3Context();

            foreach (DataModelNorthwind.Customers customer in northwind.Customers)
            {
                string name = customer.ContactName;
                string title = customer.ContactTitle;
                string[] nameParts = name.Split(' ');
                string first = nameParts[0];
                string last = nameParts[1];

                Console.WriteLine($"Käsitellään asiakasta: {first} {last}.");
            }

            Console.WriteLine("Asiakasdatan kopiointi on päättynyt.");
        }
    }
}
