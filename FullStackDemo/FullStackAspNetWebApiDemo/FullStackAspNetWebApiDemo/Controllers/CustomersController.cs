using FullStackAspNetWebApiDemo.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackAspNetWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public List<Customer> ListaaKaikki()
        {
            NorthwindContext konteksti = new NorthwindContext();
            return konteksti.Customers.ToList();
        }
    }
}
