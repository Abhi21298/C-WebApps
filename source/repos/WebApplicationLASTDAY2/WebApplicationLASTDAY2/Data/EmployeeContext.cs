using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationLASTDAY2.Models;

namespace WebApplicationLASTDAY2.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationLASTDAY2.Models.Employee> Employee { get; set; }
    }
}
