using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelcomeToTheWeb.Models;

namespace WelcomeToTheWeb.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string email)
        {
            Console.WriteLine($"Got name and email: {name}, {email}.");
            ViewData["Name"] = name;
            ViewData["Email"] = email;
            using (var writer = new StreamWriter(System.IO.File.Open($"emails.csv", FileMode.Append)))
            {
                writer.WriteLine($"{name}, {email}");
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}