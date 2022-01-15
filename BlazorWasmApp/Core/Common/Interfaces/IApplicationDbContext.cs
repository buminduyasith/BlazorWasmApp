using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        DbSet<TModel> Set<TModel>() where TModel : class;
        public DbSet<SuperHero> SuperHeros { get; set; }

    }
}
