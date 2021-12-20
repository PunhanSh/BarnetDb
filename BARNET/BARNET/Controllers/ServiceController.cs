using BARNET.BARNETDBContext;
using BARNET.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Controllers
{
    public class ServiceController : Controller
    {
        private readonly BARNETDB _context;
        public ServiceController(BARNETDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmService model = new VmService();
            model.Services = _context.Services.ToList();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Page = _context.Pages.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Subscribe = _context.Subscribes.FirstOrDefault();
            model.Works = _context.Works.ToList();
            return View(model);
        }
    }
}
