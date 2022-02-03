using Microsoft.EntityFrameworkCore;
using PostgreSQL_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PostgreSQL_CRUD.Data
{
    public interface IDataContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationTokennn = default);

    }
}
