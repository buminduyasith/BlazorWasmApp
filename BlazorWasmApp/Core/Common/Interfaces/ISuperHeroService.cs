using BlazorWasmApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Interfaces
{
    public interface ISuperHeroService
    {
        List<SuperHeroVM> GetAllSuperHeroes();
        SuperHeroVM GetSuperHeroById(int id);
    }
}
