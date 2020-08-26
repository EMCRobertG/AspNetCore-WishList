using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        private ApplicationDbContext _context;

        public void SetContext(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
           // SetContext(item);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            // SetContext(item);
            return RedirectToAction("Index");
        }
    }
}
