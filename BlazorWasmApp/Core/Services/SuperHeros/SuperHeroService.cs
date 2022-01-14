using BlazorWasmApp.Shared;
using Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.SuperHeros
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero{Id =1, Name ="Spider Man"},
            new SuperHero{Id =10, Name ="Iron Man"},
            new SuperHero{Id =12, Name ="Bat Man"},
            new SuperHero{Id =14, Name ="Hulk"},

        };
        public List<SuperHero> GetAllSuperHeroes()
        {
            return superHeroes;
        }

        public SuperHero GetSuperHeroById(int id)
        {
            return superHeroes.FirstOrDefault(x =>x.Id==id);
        }
    }
}
