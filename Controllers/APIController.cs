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
        [Route("/API")]
        public IActionResult API()
        {
            var me = new ApiModel
            {
                Name = "Brandyn", 
                FavoriteColor = "Purple", 
                FavoriteFood = "Spaghetti"
            };
            return Json(me);
        }
    }
}