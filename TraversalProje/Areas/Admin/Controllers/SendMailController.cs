using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalProje.Models;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SendMailController : Controller
    {
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMail(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("Admin", "sehriyarhaciyev@gmail.com");
            MailboxAddress mailboxAddressto = new MailboxAddress("Useer", mailRequest.ResieverMail);
            mimeMessage.From.Add(mailboxAddress);
            mimeMessage.To.Add(mailboxAddressto);
            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodybuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.Subject;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("sehriyarhaciyev@gmail.com", "eagqwkcfslortabg");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return RedirectToAction("SendMail");
        }
    }
}
