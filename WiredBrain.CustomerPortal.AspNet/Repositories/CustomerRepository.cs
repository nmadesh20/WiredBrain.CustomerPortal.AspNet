﻿using System.Linq;
using System.Threading.Tasks;
using WiredBrain.CustomerPortal.Web.Data;
using WiredBrain.CustomerPortal.Web.Models;

namespace WiredBrain.CustomerPortal.Web.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerPortalDbContext dbContext;

        public CustomerRepository()
        {
            var connection = Effort.DbConnectionFactory.CreateTransient();
            dbContext = new CustomerPortalDbContext(connection);
            if (!dbContext.Customers.Any())
                dbContext.Seed();
        }

        public async Task<Customer> GetCustomerByLoyaltyNumber(int loyaltyNumber, string returnUrl)
        {
            var customer = dbContext.Customers.SingleOrDefault(c => c.LoyaltyNumber == loyaltyNumber);
            if (customer.Succeeded)
            {
            if (!string.IsNullOrEmpty(returnUrl))
            {
            return Redirect(returnUrl);
            }
            else
            {
            return RedirectToAction("index","home");
            }
            }
            return customer;
            
        }

        public async Task SetFavorite(EditFavoriteModel model)
        {
            var customer = dbContext.Customers.SingleOrDefault(c => c.LoyaltyNumber == model.LoyaltyNumber);

            customer.FavoriteDrink = model.Favorite;
            await dbContext.SaveChangesAsync();
        }
    }
}
