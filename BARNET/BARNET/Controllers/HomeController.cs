using BARNET.BARNETDBContext;
using BARNET.Models;
using BARNET.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly BARNETDB _context;

        public HomeController(BARNETDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
