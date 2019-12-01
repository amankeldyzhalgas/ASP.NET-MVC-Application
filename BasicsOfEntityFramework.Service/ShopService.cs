using BasicsOfEntityFramework.Domain.Context;
using BasicsOfEntityFramework.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicsOfEntityFramework.Service
{
    public class ShopService
    {
        private readonly ShopContext _context;
        
        public ShopService(ShopContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> CustomerOrders(int? customerId)
        {
            var orders = _context.Orders.Include(o => o.Customer).Where(o => o.CustomerId == customerId);
            return await orders.ToListAsync();
        }
    }
}
