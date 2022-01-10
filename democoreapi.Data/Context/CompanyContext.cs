using democoreapi.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace democoreapi.Data.Context
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
