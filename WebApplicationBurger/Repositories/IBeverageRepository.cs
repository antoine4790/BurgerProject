using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBurger.Repositories
{
    public interface IBeverageRepository
    {
        public IQueryable<Beverage> GetBeverages();
        public Task<Beverage> GetBeverage(int? id);
        public Task<bool> AddBeverage(Beverage beverage);
        public Task<bool> DeleteBeverage(Beverage beverage);

        public Task<bool> UpdateBeverage(Beverage beverage);
    }
}
