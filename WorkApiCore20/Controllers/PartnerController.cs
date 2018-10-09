using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkApiCore20.Models;

namespace WorkApiCore20.Controllers
{
    [Route("api/[controller]")]
    public class PartnerController:Controller
    {
        DataContext db;
        public PartnerController(DataContext context)
        {
            db = context;
        }
        [HttpPost]
        public IActionResult Post([FromBody]PartnerModel partner)
        {

        }
    }
}
