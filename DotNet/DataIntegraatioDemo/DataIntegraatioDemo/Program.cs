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

            int rivienLkm = 0;
            foreach (DataModelNorthwind.Customers customer in northwind.Customers)
            {
                string name = customer.ContactName;

                // titteli voi olla enintään 8 merkkiä
                string title = customer.ContactTitle;
                if (title.Length > 8)
                {
                    title = title.Substring(0, 8);
                }

                // jaetaan nimikenttä etu- ja sukunimiin
                string[] nameParts = name.Split(' ');
                string first = nameParts[0];
                string last = nameParts[1];

                Console.WriteLine($"Käsitellään asiakasta: {first} {last}.");

                DataModelAdventureWorks.BusinessEntity newBusiness = new DataModelAdventureWorks.BusinessEntity()
                {
                    ModifiedDate = DateTime.Now
                };
                adventure.BusinessEntity.Add(newBusiness);

                DataModelAdventureWorks.Person newPerson = new DataModelAdventureWorks.Person()
                {
                    // kytkentä BusinessEntity-tauluun
                    BusinessEntity = newBusiness,

                    PersonType = "IN", // individual
                    FirstName = first,
                    LastName = last,
                    Title = title
                };

                adventure.Person.Add(newPerson);
                rivienLkm++;

                break;
            }

            Console.WriteLine($"Tallennetaan muutokset, {rivienLkm} riviä AdventureWorks-tietokantaan.");
            adventure.SaveChanges();
            Console.WriteLine("Tallennus tehty.");

            Console.WriteLine("Asiakasdatan kopiointi on päättynyt.");
        }
    }
}
