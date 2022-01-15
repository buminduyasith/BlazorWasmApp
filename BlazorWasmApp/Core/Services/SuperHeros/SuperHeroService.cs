using BlazorWasmApp.Shared;
using Core.Common.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.SuperHeros
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger logger;
        public SuperHeroService(IApplicationDbContext context, ILogger<SuperHeroService> logger)
        {
            _context = context;
            this.logger = logger;
        }
        private static List<SuperHeroVM> superHeroes = new List<SuperHeroVM>
        {
            new SuperHeroVM{Id =1, Name ="Spider Man"},
            new SuperHeroVM{Id =10, Name ="Iron Man"},
            new SuperHeroVM{Id =12, Name ="Bat Man"},
            new SuperHeroVM{Id =14, Name ="Hulk"},

        };
        public List<SuperHeroVM> GetAllSuperHeroes()
        {
            var superHeroes = _context.SuperHeros.Select(x=>new SuperHeroVM { Id=x.Id,Name=x.Name}).ToList();
            return superHeroes;
        }

        public SuperHeroVM GetSuperHeroById(int id)
        {
            return superHeroes.FirstOrDefault(x =>x.Id==id);
        }
    }
}
