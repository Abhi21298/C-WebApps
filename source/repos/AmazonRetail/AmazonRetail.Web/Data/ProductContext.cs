using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;
using AmazonRetail.Infrastructure.Repository;

namespace AmazonRetail.Web.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<AmazonWeb.Core.Entities.Product> Product { get; set; }

        //public DbSet<AmazonWeb.Core.Entities.Contact> Contact { get; set; }

        //public DbSet<AmazonWeb.Core.Entities.CardDetails> CardDetails { get; set; }
    }
}
