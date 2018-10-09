using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkApiCore20.Models;

namespace WorkApiCore20.Controllers
{
    [Route("api/[controller]")]
    public class PartnerController : Controller
    {
        DataContext db;
        public PartnerController(DataContext context)
        {
            db = context;
        }
        [HttpPost("GetPartner")]
        public IActionResult Post([FromBody]PartnerModel partner)
        {
            if (partner.Email == null)
            {
                return Ok(new { success = false });
            }
            PartnerModel user = db.Partners.FirstOrDefault(x => x.Email == partner.Email);
            return Ok(new
            {
                user.Id,
                user.TypeClient,
                user.OGRN,
                user.KPP,
                user.Email,
                user.Position,
                user.CorrespondentAccount,
                user.SeriesAndNumberCertificate,
                user.INN,
                user.ActingBasis,
                user.NameOrganization,
                user.OGRNIP,
                user.LegalAddress,
                user.ActualAddress,
                user.PhoneNumber,
                user.CheckingAccount,
                user.BankName,
                user.BIK,
                user.Fio,
                user.DateOfIssueCertificate
            });
        }
        [HttpPost("SetDataPartner")]
        public IActionResult SetDataPartner([FromBody]PartnerModel partner)
        {
            if (partner==null)
            {
                return Ok("Empty request");
            }
            PartnerModel client = db.Partners.FirstOrDefault(x=>x.Id==partner.Id);
            string pas = partner.Password;
            client = partner;
            client.Password = pas;
            db.SaveChanges();
            return Ok();
        }
    }
}
