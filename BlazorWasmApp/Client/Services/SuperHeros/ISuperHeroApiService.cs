using BlazorWasmApp.Shared;

namespace BlazorWasmApp.Client.Services.SuperHeros
{
    public interface ISuperHeroApiService
    {
       Task<List<SuperHero>> GetAllSuperHeros();
    }
}
