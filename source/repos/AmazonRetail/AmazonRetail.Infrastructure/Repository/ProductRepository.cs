using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Entities;

namespace AmazonRetail.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Product> Products = new List<Product>();
        public ProductRepository()
        {
            Add(new Product { Name = "Rolex1", Description = "Premium Model", ImageFile = "popular1.png", UnitPrice = 40000, UnitsInStock = 4, Star = 3.5});
            Add(new Product { Name = "Rolex2", Description = "Premium Model : Radium", ImageFile = "popular2.png", UnitPrice = 42000, UnitsInStock = 5, Star = 4.5 });
            Add(new Product { Name = "Rolex3", Description = "Premium Model : Style", ImageFile = "popular3.png", UnitPrice = 42000, UnitsInStock = 5, Star = 4.2 });
            Add(new Product { Name = "Rolex4", Description = "Limited Edition : Made in India", ImageFile = "popular4.png", UnitPrice = 42000, UnitsInStock = 5, Star = 4.2 });
            Add(new Product { Name = "Rolex5", Description = "Classic", ImageFile = "popular5.png", UnitPrice = 42000, UnitsInStock = 5, Star = 4.1 });
            Add(new Product { Name = "Rolex6", Description = "Special Edition", ImageFile = "popular6.png", UnitPrice = 42000, UnitsInStock = 5, Star = 4.9 });
        }
        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }

            Products.Add(item);
            return item;
            //throw new NotImplementedException();
        }
        public Product Get(int id)
        {
            return Products.Find(p => p.Id == id);
            //throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return Products;
            //throw new NotImplementedException();
        }
        public void Remove(int id)
        {
            Products.RemoveAll(p => p.Id == id);
            //throw new NotImplementedException();
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            int index = Products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                return false;
            Products.RemoveAt(index);
            Products.Add(item);
            return true;
            // throw new NotImplementedException();
        }

        //public Task UpdateAsync(Product entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Product> AddAsync(Product entity)
        //{
        //    if (entity == null)
        //   {
        //        throw new NotImplementedException();
        //    }
        //    return Task.WaitAny(Products.Add(entity));

        //    throw new NotImplementedException();
        //}

        //public Task DeleteAsync(Product entity)
        //{

        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Product>> GetAllAsync()
        //{
        //    //return Products;
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Product>> GetAsync(Expression<Func<Product, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Product>> GetAsync(Expression<Func<Product, bool>> predicate = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeString = null, bool disableTracking = true)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Product>> GetAsync(Expression<Func<Product, bool>> predicate = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, List<Expression<Func<Product, object>>> includes = null, bool disableTracking = true)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Product> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<Product>> GetProductByNameAsync(string ProductName)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<Product>> GetProductListAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
