
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationBurger.Repositories
{
    public interface IMenuRepository
    {
        public IQueryable<Menu> GetMenu();
        public void AddMenu(Menu menu);
        public void DeleteMenu(Menu menu);
    }
}