using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetWebApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // vastaa osoitteessa: /api/customers
        [HttpGet]
        public List<Customers> PalautaKaikki()
        {
            NorthwindContext konteksti = new NorthwindContext();
            List<Customers> kaikki = konteksti.Customers.ToList();

            return kaikki;
        }

        // vastaa osoitteessa: /api/customers/NIMI
        [HttpGet]
        [Route("{customerId}")]
        public Customers PalautaYksittäinen(string customerId)
        {
            NorthwindContext konteksti = new NorthwindContext();
            Customers asiakas = konteksti.Customers.Find(customerId);

            return asiakas;
        }

        [HttpPost]
        public bool LisääUusi()
        {
            NorthwindContext konteksti = new NorthwindContext();

            Customers uusi = new Customers()
            {
                CustomerId = "UUSI1",
                CompanyName = "C#-koodin kautta lisätty",
                ContactName = "Teppo Testaaja",
                Country = "Finland",
                Phone = "050 987 6543"
            };

            konteksti.Customers.Add(uusi);
            konteksti.SaveChanges();

            return true;
        }
    }
}
