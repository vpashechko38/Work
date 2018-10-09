using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkApiCore20
{
    public class Crypt
    {
        public static string GenerateApiKey(string login)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string data = Convert.ToString(DateTime.Now);
            byte[] byteMas = md5.ComputeHash(Encoding.UTF8.GetBytes(login + data));
            string Apikey = BitConverter.ToString(byteMas).Replace("-", String.Empty);
            return Apikey;
        }
        public static string GeneratePassword(string login, string password)
        {
            SHA256 md5 = new SHA256CryptoServiceProvider();
            string sult = "Ыяменткыр";
            byte[] byteMas = md5.ComputeHash(Encoding.UTF8.GetBytes(password + sult));
            string passwordMD5 = BitConverter.ToString(byteMas).Replace("-", String.Empty);

            byte[] byteLogin = md5.ComputeHash(Encoding.UTF8.GetBytes(login));
            string loginMD5 = BitConverter.ToString(byteLogin).Replace("-", String.Empty);

            SHA256 sHA = new SHA256CryptoServiceProvider();

            byte[] vs = sHA.ComputeHash(Encoding.UTF8.GetBytes(loginMD5 + passwordMD5));
            string HashPassword = BitConverter.ToString(vs).Replace("-", String.Empty);
            return HashPassword;
        }
    }
}
