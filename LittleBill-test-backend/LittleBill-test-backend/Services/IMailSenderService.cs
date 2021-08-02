using LittleBill_test_backend.Helpers;
using LittleBill_test_backend.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Services
{
    public interface IMailSenderService
    {
        void Send(User user);
    }


    public class MailSenderService : IMailSenderService
    {
        private readonly AppSettings _appSettings;
        public MailSenderService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;

        }

        public void Send(User user)
        {
            string mailBody = MailBody(user);
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(_appSettings.Mail);
                message.To.Add(new MailAddress(user.Email));
                message.Subject = "Little Bill - Reset Password";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = mailBody;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_appSettings.Mail, _appSettings.Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }

        private string MailBody(User user)
        {
            string resetToken = $"http://localhost:4000/pwTokenVerify/{generateJwtToken(user)}";
            string mail = File.ReadAllText("./MailTemplate/mailPage.html");
            mail = mail.Replace("@Name", $"{user.Name}");
            mail = mail.Replace("@tokenLink", $"{resetToken}");
            return mail;
        }

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.ResetMailSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
