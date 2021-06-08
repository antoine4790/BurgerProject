using Dal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBurger.Controllers
{
    public class BeveragesController : Controller
    {
        private readonly BurgerContext _context;
        public BeveragesController(BurgerContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Beverages.ToList());
        }
    }
}
