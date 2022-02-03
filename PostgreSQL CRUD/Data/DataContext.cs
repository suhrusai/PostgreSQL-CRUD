using Microsoft.EntityFrameworkCore;
using PostgreSQL_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSQL_CRUD.Data
{
    public class DataContext : DbContext , IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<Product> Products { get; set; }
    }
}
