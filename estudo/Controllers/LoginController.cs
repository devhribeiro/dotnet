using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using estudo.Models;

namespace estudo.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration configuration;

        public IActionResult index()
        {
            return View();
        }

        public IActionResult recuperar()
        {
            // string Path = request.GetRequestContext().VirtualPathRoot;
            return View();
        }
    }
}