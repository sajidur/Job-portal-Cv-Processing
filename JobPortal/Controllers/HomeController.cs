using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Pdf.Drawing;
using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;
using  System.IO;
using JobPortal.BL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Path = System.IO.Path;

namespace JobPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly JobPortalDbContext _context;
        private CandidateInfo candidate;

        public HomeController(JobPortalDbContext context)
        {
            _context = context;
        }
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> JobSettings([Bind("Id,JobId,JobTitle,Company,vacancy,TopSkills,MinorSkills")] JobSettings jobSettings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobSettings);
               
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobSettings);
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
        public IActionResult Upload(IFormFile file)
        {
            var fileName = file.FileName;
            //Parser parser = new Parser();
            //parser.ParseData();

            //var path = Path.Combine(hostingEnvironment.WebRootPath, "Attchment");

            // var filePath = Path.Combine(path, fileName);
            //FileInp

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Attchment", fileName);
            using (var fileStream=new FileStream(path,FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Process(IFormFile file)
        {

            var fileName = file.FileName;
            if (fileName != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Attchment", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }

            Parser parser = new Parser();
            DataTable dt = parser.ParseData();

            foreach (DataRow row in dt.Rows)
            {
                candidate = new CandidateInfo();
                candidate.Name = row["name"].ToString();
                candidate.Email = row["email"].ToString();
                candidate.Phone = row["phone"].ToString();
                candidate.Skills = row["skills"].ToString();
                candidate.Summary = row["summary"].ToString();
                candidate.Experience = row["experience"].ToString();
                candidate.Education = row["education"].ToString();
                 // candidate. = row["interests"].ToString();

                 if (ModelState.IsValid)
                 {
                     _context.Add(candidate);                   
                    await _context.SaveChangesAsync();
                     //return RedirectToAction(nameof(Index));
                 }

               


            }
            return View();
        }



        public JsonResult GetFIlterJsonResult(string jobCategory,string skills,string location)
        {
            //var sa = new JsonSerializerSettings();
            //List<CandidateInfo> candidateList=new List<CandidateInfo>();
            //candidateList = _context.Candidate.ToList();
            IEnumerable<CandidateInfo> candidateList = _context.Candidate.ToList();
            ////return Json(courses, JsonRequestBehavior.AllowGet);
            return Json(candidateList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
