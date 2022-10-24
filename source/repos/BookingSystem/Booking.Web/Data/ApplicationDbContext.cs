using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking.Core.Entities;

namespace Booking.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Booking.Core.Entities.Movie> Movie { get; set; }

        //public DbSet<Booking.Core.Entities.BookingItem> BookingItem { get; set; }
        //public DbSet<Booking.Core.Entities.Booking> Booking { get; set; }

    }
}
