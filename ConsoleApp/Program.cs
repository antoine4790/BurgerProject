using Dal;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BurgerContext())
            {
                context.Initialize(true);

                foreach (var item in context.Products.AsNoTracking())
                {
                    Console.WriteLine($"{item.Name} {item.Price}");
                }

            }
        }
    }
}
