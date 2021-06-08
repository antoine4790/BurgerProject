using ClassLibrary;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBurger.Repositories
{
    public class BeverageRepository : IBeverageRepository
    {
        private readonly BurgerContext _context;
        public BeverageRepository(BurgerContext context)
        {
            _context = context;
        }
        public async Task<bool> AddBeverage(Beverage beverage)
        {
            try
            {
                _context.Add(beverage);
                //_context.SaveChanges();
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool DeleteBeverage(Beverage beverage)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Beverage> GetBeverages()
        {
            throw new NotImplementedException();
        }

        public bool UpdateBeverage(Beverage beverage)
        {
            throw new NotImplementedException();
        }
    }
}
