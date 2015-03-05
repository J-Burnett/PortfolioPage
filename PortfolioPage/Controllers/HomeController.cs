using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace PortfolioPage.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Name, string Email, string Phone, string Message)
        {
            var message = new MailMessage("contactjuliannaburnett@seedpaths.com", "julianna.burnett@gmail.com");
            var client = new SmtpClient("mail.dustinkraft.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1")
            }; 
            message.Body = Name + " tried to contact you. Their email is " + Email  + " and their number is " + Phone + ". The message they left was: \"" + Message + "\"";
            message.Subject = "Someone wants to contact you!";
            client.Send(message);

            ViewBag.Message = "Thank you for getting in touch! I will contact you soon!";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}