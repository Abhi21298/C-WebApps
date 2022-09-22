using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AmazonRetail.Infrastructure.Repository
{
    class CartRepository : ICartRepository
    {
        List<Cart> Carts = new List<Cart>();
    
        public Cart Add(Cart item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }

            Carts.Add(item);
            return item;
            //throw new NotImplementedException();
        }

        public Cart Get(int id)
        {
            return Carts.Find(p => p.Id == id);
            //throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetAll()
        {
            return Carts;
            //throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            Carts.RemoveAll(p => p.Id == id);
            //throw new NotImplementedException();
        }

        public bool Update(Cart item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            int index = Carts.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                return false;
            Carts.RemoveAt(index);
            Carts.Add(item);
            return true;
            //throw new NotImplementedException();
        }

        //public Task<Cart> AddAsync(Cart entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DeleteAsync(Cart entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Cart>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Cart>> GetAsync(Expression<Func<Cart, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Cart>> GetAsync(Expression<Func<Cart, bool>> predicate = null, Func<IQueryable<Cart>, IOrderedQueryable<Cart>> orderBy = null, string includeString = null, bool disableTracking = true)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Cart>> GetAsync(Expression<Func<Cart, bool>> predicate = null, Func<IQueryable<Cart>, IOrderedQueryable<Cart>> orderBy = null, List<Expression<Func<Cart, object>>> includes = null, bool disableTracking = true)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Cart> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Cart> GetByUserNameAsync(string UserName)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateAsync(Cart entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
