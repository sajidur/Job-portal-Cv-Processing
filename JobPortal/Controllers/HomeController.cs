using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;
using JobPortal.BL;

namespace JobPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult JobSettings()
        {
            return View();
        }
        public IActionResult Import()
        {
            return View();
        }
        public IActionResult Filter()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ImportList(EmailSettings model)
        {
            var client = new MailRepository();
           // client.Connect(hostname: "imap.gmail.com", username: "taherasiddqua@gmail.com", password: "taherasiddqua007", port: 995, isUseSsl: true);
            client.Connect(hostname: model.Host, username: model.UserName, password: model.Password, port: 995, isUseSsl: true);
            var allMail = client.GetMail();
            var emailList = new List<EmailMessage>();
            foreach (var mail in allMail)
            {
                var email = new EmailMessage();
                var subject = mail.Message.Headers.Subject;
                var to = string.Join(",", mail.Message.Headers.To.Select(m => m.Address));
                var from = mail.Message.Headers.From.Address;

                Console.WriteLine("Email Subject: {0}", subject);
                Console.WriteLine("Sent To: {0}", to);
                Console.WriteLine("Sent From: {0}", from);
                email.From = from;
                email.Subject = subject;
                email.Body = mail.Message.ToMailMessage().Body;
                var attachments = client.GetAttachments(mail.Message);

                if (attachments.Any())
                {
                    // foreach (var attachment in attachments)
                    // {

                    // Console.WriteLine("File Location: {0}", attachment);
                    //}
                    email.CV = string.Join(',', attachments);
                }
                else
                {
                    Console.WriteLine("Email has no attachments, if attachments are required, make sure to not delete this email");
                }
                //  var mailWithAttachments = client.GetMail(fromAddress:from);

                //foreach (var mailwithAtt in mailWithAttachments)
                //{

                //    client.Delete(mailwithAtt.MessageNumber);
                //}
                // client.Delete(mail.MessageNumber);
                emailList.Add(email);
            }
            return View(emailList);
        }

        [HttpPost]
        public IActionResult Process(EmailSettings model)
        {
            Parser parser = new Parser();
            parser.ParseData();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
