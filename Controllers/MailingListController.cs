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
    public class MailingListController : Controller
    {
        public IActionResult Index()
        {
            var peopleList = new List<string>();

            using (var reader = new StreamReader(System.IO.File.Open($"emails.csv", FileMode.Open)))
            {
                while(reader.Peek() >= 0)
                {
                    var datafromFile = reader.ReadLine();
                    var data = datafromFile.Split(',');
                   
                    foreach (var item in data)
                    {
                        peopleList.Add(item); 
                        Console.WriteLine(item);
                    }                    
                }
            }
            return View(peopleList);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}