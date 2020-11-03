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
        public List<Customers> PalautaKaikki()
        {
            NorthwindContext konteksti = new NorthwindContext();
            List<Customers> kaikki = konteksti.Customers.ToList();

            return kaikki;
        }

        // vastaa osoitteessa: /api/customers/NIMI
        [Route("{customerId}")]
        public Customers PalautaYksittäinen(string customerId)
        {
            NorthwindContext konteksti = new NorthwindContext();
            Customers asiakas = konteksti.Customers.Find(customerId);

            return asiakas;
        }
    }
}
