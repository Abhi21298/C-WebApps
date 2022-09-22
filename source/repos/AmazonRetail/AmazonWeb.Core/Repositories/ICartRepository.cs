using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWeb.Core.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        //Task<Cart> GetByUserNameAsync(string UserName);
    }
}
