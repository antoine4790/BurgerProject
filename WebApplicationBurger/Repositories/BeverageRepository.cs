using ClassLibrary;
using Dal;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> DeleteBeverage(Beverage beverage)
        {
            var beverageFound = await _context.Beverages.FindAsync(beverage.Id);
            if (beverageFound != null)
            {
                _context.Beverages.Remove(beverageFound);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public IQueryable<Beverage> GetBeverages()
        {
            throw new NotImplementedException();
        }
        public async Task<Beverage> GetBeverage(int? id)
        {
            var beverage = await _context.Beverages.FirstOrDefaultAsync(m => m.Id == id);
            return beverage;
        }

        public async Task<bool> UpdateBeverage(Beverage beverage)
        {
            throw new NotImplementedException();
        }
    }
}
