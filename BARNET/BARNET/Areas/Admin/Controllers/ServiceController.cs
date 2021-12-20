using BARNET.BARNETDBContext;
using BARNET.Models;
using BARNET.Models.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ServiceController : Controller
    {
        private readonly BARNETDB _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ServiceController(BARNETDB context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            VmService model = new VmService();
            model.Services = _context.Services.ToList();
            model.Page = _context.Pages.FirstOrDefault();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Subscribe = _context.Subscribes.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Works = _context.Works.ToList();


            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length <= 2000000)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }
                        model.Image = fileName;
                        _context.Services.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(model);

                    }
                }
                else
                {
                    return View(model);
                }
            }

            return View(model);

        }
        public IActionResult Update(int id)
        {
            return View(_context.Services.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Service model)
        {
            if (model.ImageFile != null)
            {
                if (ModelState.IsValid)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length <= 2000000)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }
                            model.Image = fileName;
                            _context.Services.Update(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return View(model);

                        }
                    }
                    else
                    {
                        return View(model);
                    }
                }
            }
            else
            {
                return RedirectToAction("Update");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Service service = _context.Services.Find(id);
            _context.Services.Remove(service);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
