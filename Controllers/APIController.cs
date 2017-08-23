using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelcomeToTheWeb.Models;

namespace WelcomeToTheWeb.Controllers
{
    public class APIController : Controller
    {
        
        public IActionResult Index()
        {
            var me = new ApiModel
            {
                Name = "Brandyn", 
                FavoriteColor = "Purple", 
                FavoriteFood = "Spaghetti"
            };
            return Json(me);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}