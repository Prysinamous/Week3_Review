using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Week3_Review.Models;
using Microsoft.EntityFrameworkCore;

namespace Week3_Review.Controllers
{
    public class HomeController : Controller
    {
        
        private ContactContext context { get; set; }

        public HomeController(ContactContext ccx)
        {
            context = ccx;
        
        }


        public IActionResult Index()
        {
            return View();
        }

       


    }
}
