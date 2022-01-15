using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Extensions.Seeds
{
    public static class SuperHeroSeed
    {
        public static void SeedSuperHeros(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero { Id = 1, Name="Spider Man" },
                new SuperHero { Id = 2,Name="Bad Man" }
               
            );
        }
    }
}
