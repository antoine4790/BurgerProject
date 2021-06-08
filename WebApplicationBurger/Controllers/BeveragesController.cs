using ClassLibrary;
using Dal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBurger.Repositories;

namespace WebApplicationBurger.Controllers
{
    public class BeveragesController : Controller
    {
        private readonly BurgerContext _context;
        private readonly IBeverageRepository _beverageRepository;
        public BeveragesController(BurgerContext context, IBeverageRepository beverageRepository)
        {
            _context = context;
            _beverageRepository = beverageRepository;
        }
        public IActionResult Index()
        {
            return View(_context.Beverages.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("millimiter,isCarbonated,Id,Price,Name,Description")] Beverage beverage)
        {
            if(await _beverageRepository.AddBeverage(beverage))
                return RedirectToAction("Index");
            else 
                return BadRequest();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beverage = await _beverageRepository.GetBeverage(id);
            if (beverage == null)
            {
                return NotFound();
            }

            return View(beverage);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("millimiter,isCarbonated,Id,Price,Name,Description")] Beverage beverage)
        {
            if (await _beverageRepository.DeleteBeverage(beverage))
                return RedirectToAction("Index");
            else
                return NotFound();
        }
    }
}
