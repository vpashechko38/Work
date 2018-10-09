using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WorkApiCore20
{
    public class Mail
    {
    }
    class SendMail
    {
        public static void SendToken(int id, string mail, string password)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("test.testovyj.18@bk.ru", "Test");
            // кому отправляем
            MailAddress to = new MailAddress(mail);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to)
            {
                // тема письма
                Subject = "Здесь должен быть заголовок",
                // текст письма
                Body = $"Здесь должен быть основной текст письма <br> <a href='http://localhost:8080/api/registration/confirmation/api={Crypt.GenerateApiKey(mail)}&id={id}'>Нажмите сюда для подтверждения регистрации</a> <br> Ваш логин: {mail} <br> Ваш пароль: {password}",
                // письмо представляет код html
                IsBodyHtml = true
            };
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25)
            {
                // логин и пароль
                Credentials = new NetworkCredential("test.testovyj.18@bk.ru", "36Vlad"),
                EnableSsl = true
            };
            smtp.SendMailAsync(m);
        }
    }
}
