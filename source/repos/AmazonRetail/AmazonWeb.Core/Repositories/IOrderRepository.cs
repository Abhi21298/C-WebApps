using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWeb.Core.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        //Task<IEnumerable<Order>> GetOrderByUserNameAsync(string UserName);
    }
}
