using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FileuploadMvc.Models;

namespace FileuploadMvc.Controllers
{
    public class LogIn : Controller
    { 
        LogIn login = new LogIn();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View(login);
            // Return a success response; consider returning a token if using JWT.
           
        }
    }
}
