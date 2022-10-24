using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Web.Data
{
    public class OrderHistory1DbContext : DbContext
    {
        public OrderHistory1DbContext(DbContextOptions<OrderHistory1DbContext> options)
            : base(options)
        {

        }

        public DbSet<Booking.Core.Entities.OrderHistory> OrderHistory { get; set; }

    }
}
