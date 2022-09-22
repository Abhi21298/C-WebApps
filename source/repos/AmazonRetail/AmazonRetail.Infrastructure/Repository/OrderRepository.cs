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
    class OrderRepository : IOrderRepository
    {
        List<Order> Orders = new List<Order>();
        public Order Add(Order item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }

            Orders.Add(item);
            return item;
            //throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            return Orders.Find(p => p.Id == id);
            //throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            return Orders;
            //throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            Orders.RemoveAll(p => p.Id == id);
            //throw new NotImplementedException();
        }

        public bool Update(Order item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            int index = Orders.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                return false;
            Orders.RemoveAt(index);
            Orders.Add(item);
            return true;
            //throw new NotImplementedException();
        }

        //public Task UpdateAsync(Order entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Order> AddAsync(Order entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DeleteAsync(Order entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Order>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Order>> GetAsync(Expression<Func<Order, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Order>> GetAsync(Expression<Func<Order, bool>> predicate = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeString = null, bool disableTracking = true)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IReadOnlyList<Order>> GetAsync(Expression<Func<Order, bool>> predicate = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, List<Expression<Func<Order, object>>> includes = null, bool disableTracking = true)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Order> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<Order>> GetOrderByUserNameAsync(string UserName)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
