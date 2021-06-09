using ClassLibrary;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBurger.Repositories
{
    public class MenuRepository : IMenuRepository
    {

        private BurgerContext _context;

        public MenuRepository(BurgerContext context)
        {
            this._context = context;
        }

        public IQueryable<Menu> GetMenu()
        {
            return _context.Menus;
        }
        public void AddMenu(Menu menu)
        {
             _context.Menus.Add(menu);
             _context.SaveChanges();

        }

        public void DeleteMenu(Menu menu)
        {
            throw new NotImplementedException();
        }


        


    }
}
