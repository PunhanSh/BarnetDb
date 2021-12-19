using BARNET.BARNETDBContext;
using BARNET.Models;
using BARNET.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogController : Controller
    {
        private readonly BARNETDB _context;
        public BlogController(BARNETDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmBlog model = new VmBlog();
            model.Blogs = _context.Blogs.ToList();
            model.BlogCategories = _context.BlogCategories.ToList();


            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (ModelState.IsValid)
            {
                _context.Blogs.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Blogs.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Blog model)
        {
            if (ModelState.IsValid)
            {
                _context.Blogs.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Blog blog = _context.Blogs.Find(id);
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
