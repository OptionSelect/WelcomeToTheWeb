using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelcomeToTheWeb.Models;

namespace WelcomeToTheWeb.Controllers
{
    public class UserIDController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}