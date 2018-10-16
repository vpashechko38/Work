using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkApiCore20.Models;

namespace WorkApiCore20.Controllers
{
    [Route("api/[controller]")]
    public class OrderModel:Controller
    {
        DataContext db;
        public OrderModel(DataContext context)
        {
            db = context;
        }


        //[HttpPost("getid")]
        //public IActionResult GetId([FromBody]Order order)
        //{
        //    db.Orders.Add(order);
        //}

    }
}
