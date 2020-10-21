using EntityFrameworkDemo.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using EntityFrameworkDemo.TemperatureModels;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi Entity Framework!");

            NorthwindContext entities = new NorthwindContext();

            List<Customers> suomalaiset = (from c in entities.Customers
                                           where c.Country == "Finland"
                                           orderby c.CompanyName
                                           select c).ToList();

            foreach (Customers asiakas in suomalaiset)
            {
                Console.WriteLine(asiakas.CompanyName);
            }

            Console.WriteLine("------------------");

            TemperaturesContext context = new TemperaturesContext();
            
            // "query syntax"
            List<Temperatures> merkinnät = (from t in context.Temperatures
                                            where t.ValueDate > new DateTime(2020, 10, 1)
                                            select t).ToList();
            // "method syntax"
            List<Temperatures> merkinnät2 =
                context.Temperatures.Where(t => t.ValueDate > new DateTime(2020, 10, 1)).ToList();

            foreach (Temperatures merkintä in merkinnät)
            {
                Console.WriteLine(merkintä.ValueDate + ": " + merkintä.TemperatureValue);
            }
            /*
            foreach (Temperatures merkintä in merkinnät2)
            {
                Console.WriteLine(merkintä.ValueDate + ": " + merkintä.TemperatureValue);
            }
            */
        }
    }
}
