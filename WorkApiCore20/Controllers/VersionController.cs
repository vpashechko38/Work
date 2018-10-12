using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkApiCore20.Models;

namespace WorkApiCore20.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        DataContext db;
        public VersionController(DataContext context)
        {
            db = context;
        }
        [HttpGet("actualversion")]
        public IActionResult Get()
        {
            return Ok(db.Versions.FirstOrDefault(x => x.Id == 0).ActualVersion);
        }
        [HttpPost]
        public IActionResult Post([FromBody]VersionApp version)
        {
            if (db.Versions.FirstOrDefault(x => x.Id == 0) == null)
            {
                db.Versions.Add(version);
                db.SaveChanges();
                return Ok("success");
            }
            else
            {
                return Ok("Версия уже задана, обновите ее значение в БД");
            }
        }
        [HttpPost("update")]
        public IActionResult Put([FromBody]VersionApp version)
        {
            VersionApp app = db.Versions.FirstOrDefault(x => x.Id == 0);
            if ( app == null)
            {
                return Ok("Нет записи в БД, изначально ее необходимо создать");
            }
            app.ActualVersion = version.ActualVersion;
            db.SaveChanges();
            return Ok($"{app.ActualVersion}");

        }
    }
}
