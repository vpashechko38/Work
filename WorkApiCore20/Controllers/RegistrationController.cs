using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkApiCore20.enumerators;
using WorkApiCore20.Models;

namespace WorkApiCore20.Controllers
{
    [Route("api/[controller]")]
    public class RegistrationController:Controller
    {
        DataContext db;
        public RegistrationController(DataContext context)
        {
            db = context;
        }
        //[HttpPost]
        //public IActionResult Post([FromBody]UserModel user)
        //{
        //    try
        //    {
        //        if (user == null)
        //        {
        //            return Ok(new { success = false, message = "Empty Request" });
        //        }
        //        UserModel client = db.Users.FirstOrDefault(x => x.Email == user.Email);
        //        if (client == null)
        //        {
        //            return Ok(new { success = false, message = "User not found" });
        //        }
        //        if (Crypt.GeneratePassword(user.Email, user.Password) != client.Password)
        //        {
        //            return Ok(new { success = false, message = "Unable to log in" });
        //        }
        //        LicenseModel license = db.Licenses.FirstOrDefault(x => x.UserId == client.Id);
        //        if (license.LifeTime > DateTime.Today)
        //        {
        //            return Ok(new { success = false, message = "license expired" });
        //        }
        //        client.ApiKey = Crypt.GenerateApiKey(client.Email);
        //        db.SaveChanges();
        //        return Ok(new { success = true, message = client.ApiKey });
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok(new { success = false, message = e.Message });
        //    }
        //}
        [HttpPost("")]
        public IActionResult Give([FromBody] PartnerModel[] userModels)
        {
            if (userModels==null)
            {
                return Ok(new { success = false });
            }
            return Ok(new { success = true });
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PartnerModel user = db.Users.FirstOrDefault(x => x.Id == id);
            switch (user.TypeClient)
            {
                case (int)TypeClient.Fizicial:
                    if (user == null)
                    {
                        return Ok(new { success = false, message = "Пользователь не найден" });
                    }
                    return Ok(new {
                        user.Id,
                        user.Fio,
                        user.TypeClient,
                        user.ActualAddress,
                        user.PhoneNumber,
                        user.Email,
                        user.SeriesAndNumberPasport,
                        user.IssuedByPasport,
                        user.DateOfIssuePasport,
                        user.UnitCodePasport
                    });
                case (int)TypeClient.Individual:
                    return Ok(new {
                        user.Id,
                        user.TypeClient,
                        user.INN,
                        user.OGRNIP,
                        user.LegalAddress,
                        user.ActualAddress,
                        user.PhoneNumber,
                        user.CheckingAccount,
                        user.BankName,
                        user.BIK,
                        user.CorrespondentAccount,
                        user.Fio,
                        user.SeriesAndNumberCertificate,
                        user.DateOfIssueCertificate
                    });
                case (int)TypeClient.UristFace:
                    return Ok(new {
                        user.Id,
                        user.TypeClient,
                        user.INN,
                        user.OGRN,
                        user.KPP,
                        user.LegalAddress,
                        user.ActualAddress,
                        user.PhoneNumber,
                        user.Email,
                        user.CheckingAccount,
                        user.BankName,
                        user.BIK,
                        user.CorrespondentAccount,
                        user.Fio,
                        user.Position,
                        user.ActingBasis
                    });
            }
            return Ok(new { success = true, message = user });
        }
        [HttpGet("confirmation/api={api}&id={id}")]
        public IActionResult Confirmation(string api, int id)
        {
            PartnerModel user = db.Users.FirstOrDefault(x=>x.Id==id);
            user.Success = true;
            db.SaveChanges();
            return Ok(new { success = true });
        }
        [HttpPost("register")]
        public IActionResult Registration([FromBody]PartnerModel user)
        {
            try
            {
                if (user == null)
                {
                    return Ok(new { success = false, message = "Пустой запрос" });
                }
                string password = user.Password;
                user.Password = Crypt.GeneratePassword(user.Email, user.Password);
                db.Users.Add(user);
                db.SaveChanges();
                SendMail.SendToken(db.Users.FirstOrDefault(x=>x.Password==user.Password).Id,user.Email, password);
                return Ok(new { success = true, message = user });
            }
            catch (Exception e)
            {
                return Ok(new { success = false, message = e.Message });
            }
        }
        [HttpPost("auth")]
        public IActionResult Authorization([FromBody]PartnerModel user)
        {
            try
            {
                if (user == null)
                {
                    return Ok("Пустой запрос");
                }
                PartnerModel client = db.Users.FirstOrDefault(x => x.Email == user.Email);
                if (client == null)
                {
                    return Ok("Пользователь не найден");
                }
                if (Crypt.GeneratePassword(user.Email, user.Password) != client.Password)
                {
                    return Ok("Логин или пароль не найдет");
                }
                LicenseModel license = db.Licenses.FirstOrDefault(x => x.UserId == client.Id);
                if (license.LifeTime > DateTime.Today)
                {
                    return Ok("Ваша лицензия истекла");
                } 
                db.SaveChanges();
                return Ok("success");
            }
            catch (Exception e)
            {
                return Ok(new { success = false, message = e.Message });
            }
        }
    }
}
