using ClassLibrary;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBurger.Services
{
    public class MenuService
    {
        private readonly BurgerContext _context;

        public MenuService(BurgerContext context)
        {
            _context = context;
        }


        public List<Beverage> GetBeverages()
        {
            return _context.Beverages.ToList();
        }

        public List<Side> GetSides()
        {
            return _context.Sides.ToList();
        }

        public List<Burger> GetBurgers()
        {
            return _context.Burgers.ToList();
        }

        public List<Dessert> GetDesserts()
        {
            return _context.Desserts.ToList();
        }

        
    }
}
