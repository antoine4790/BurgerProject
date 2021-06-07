using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class BurgerContextExtension
    {
        public static void Initialize(this BurgerContext context, bool dropAlways = false)
        {
            //To drop database or not
            if (dropAlways)
                context.Database.EnsureDeleted();

            context.Database.EnsureCreated();


            //if db has been already seeded
            if (context.Products.Any())
                return;


            #region Burger
            var burgers = new List<Burger>()
            {
                new Burger
                {
                    Name = "Texas Burger",
                    Price = 12,
                    Weight = 500,
                    BeefWeight = 300,
                },
                new Burger
                {
                    Name = "Vegan Burger",
                    Price = 15,
                    Weight = 400,
                    BeefWeight = 0,
                },
                new Burger
                {
                    Name = "French Burger",
                    Price = 16,
                    Weight = 600,
                    BeefWeight = 200,
                    Description = "With 4 cheeses"
                },
            };
            context.Burgers.AddRange(burgers);
            #endregion

            #region Desserts
            var desserts = new List<Dessert>()
            {
                new Dessert
                {
                    Name = "Texas Ice",
                    Price = 12,
                    millimeter = 500,
                    isFrozen = true,
                },
                new Dessert
                {
                    Name = "Vegan Ice",
                    Price = 15,
                    millimeter = 400,
                    isFrozen = false,
                },

            };
            context.Desserts.AddRange(desserts);
            #endregion

            #region Side
            var sides = new List<Side>()
            {
                new Side
                {
                    Name = "Texas Side",
                    Price = 12,
                    Weight = 500,
                    SaltWeight = 20,
                },
                new Side
                {
                    Name = "Vegan Side",
                    Price = 15,
                    Weight = 400,
                    SaltWeight = 46,
                },

            };
            context.Sides.AddRange(sides);
            #endregion

            #region Beverage
            var beverages = new List<Beverage>()
            {
                new Beverage
                {
                    Name = "Texas Beverage",
                    Price = 12,
                    millimiter = 500,
                    isCarbonated = true,
                },
                new Beverage
                {
                    Name = "Vegan Beverage",
                    Price = 15,
                    millimiter = 400,
                    isCarbonated = false,
                },

            };
            context.Beverages.AddRange(beverages);
            #endregion

            context.SaveChanges();
        }
    }
}
