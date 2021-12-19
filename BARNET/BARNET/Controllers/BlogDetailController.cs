using BARNET.BARNETDBContext;
using BARNET.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly BARNETDB _context;
        public BlogDetailController(BARNETDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBlog model = new VmBlog();
            model.Blogs = _context.Blogs.Include("BlogCategory").Include("User").ToList();
            model.BlogCategories = _context.BlogCategories.ToList();
            model.Users = _context.Users.ToList();
            model.Banner = _context.Banners.FirstOrDefault();
            return View(model);
        }
    }
}
