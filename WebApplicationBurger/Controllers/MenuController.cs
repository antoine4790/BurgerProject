using ClassLibrary;
using Dal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBurger.Repositories;


namespace WebApplicationBurger.Controllers
{
    public class MenuController : Controller
    {




        private readonly BurgerContext _context;
        private readonly IMenuRepository _menuRepository;
        public MenuController(BurgerContext context, IMenuRepository menuRepository)
        {
            _context = context;
            _menuRepository = menuRepository;
        }
        // GET: MenuController
        public ActionResult Index()
        {

            return View(_context.Menus.ToList());
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Menu menu)
        {
            _menuRepository.AddMenu(menu);
           return    RedirectToAction("Index");
     
        }

        // POST: MenuController/Create
        

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
