using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkApiCore20.Models;

namespace WorkApiCore20.Controllers
{
    [Route("api/[controller]")]
    public class PriceController:Controller
    {
        DataContext db;
        public PriceController(DataContext context)
        {
            db = context;
        }
        [HttpGet("fullPrice")]
        public IActionResult GetPrice()
        {
            return Ok(db.Prices.ToList());
        }
        [HttpPost]
        public IActionResult SumPrice([FromBody]Price[] price)
        {
            double itog = 0;
            foreach (var item in price)
            {
                itog += item.PricePosition;
            }
            return Ok(itog);
        }
    }
}
