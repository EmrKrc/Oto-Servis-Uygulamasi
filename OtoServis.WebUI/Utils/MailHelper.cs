using OtoServis.Entities;
using System.Net;
using System.Net.Mail;

namespace OtoServis.WebUI.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Musteri musteri)
        {
            SmtpClient smtpClient = new SmtpClient("mail.siteadresi.com", 587);
            smtpClient.Credentials = new NetworkCredential("emailKullanıcıad", "emailşifre");
            smtpClient.EnableSsl = true;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("info@siteadi.com");
            message.To.Add("info@siteadi.com");
            message.Subject = "Mesaj geldi";
            message.Body = $"Mail Bilgi Veren <hr/> Ad Soyad : {musteri.Adi} {musteri.Soyadi} <hr/> İlgilendiği Araç Id : {musteri.AracId} <hr/> Email : {musteri.Email} <hr/> Telefon : {musteri.Telefon} <hr/> Notlar : {musteri.Notlar}";
            message.IsBodyHtml = true;
            //smtpClient.Send(message);
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();
            
        }
    }
}
