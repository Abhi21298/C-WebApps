using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AmazonWeb.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
namespace AmazonRetail.Infrastructure.Data
{
    public class AmazonWebContext : IdentityDbContext<IdentityUser> 
    {
        public AmazonWebContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<List> Lists { get; set; }
        //public DbSet<ProductList> ProductLists { get; set; }
        //public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Tag> Tags { get; set; }
        //public DbSet<Specification> Specifications { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelbuilder)
       // {
            //modelbuilder.entity<product>().totable("product");
            //modelbuilder.entity<cart>().totable("cart");
            //modelbuilder.entity<cartitem>().totable("cartitem");
            //modelbuilder.entity<order>().totable("order");
            //modelbuilder.entity<orderitem>().totable("orderitem");
            //modelbuilder.entity<list>().totable("list");
            //modelbuilder.entity<productlist>().totable("productlist");
           // modelbuilder.entity<contact>().totable("contact");
            //modelbuilder.entity<tag>().totable("tag");
            //modelbuilder.entity<specification>().totable("specification");
            //modelbuilder.entity<review>().totable("review");
            //base.OnModelCreating(builder);
        //}
    }
}
