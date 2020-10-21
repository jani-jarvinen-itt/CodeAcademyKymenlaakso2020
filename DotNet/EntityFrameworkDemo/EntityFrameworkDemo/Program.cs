using EntityFrameworkDemo.Models;
using System;
using System.Linq;
using System.Collections.Generic;

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
        }
    }
}
