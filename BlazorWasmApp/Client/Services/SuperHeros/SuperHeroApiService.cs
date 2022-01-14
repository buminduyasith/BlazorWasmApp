using BlazorWasmApp.Shared;
using System.Net.Http.Json;

namespace BlazorWasmApp.Client.Services.SuperHeros
{
    public class SuperHeroApiService : ISuperHeroApiService
    {
        public readonly HttpClient _httpClient;
        public SuperHeroApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<SuperHero>> GetAllSuperHeros()
        {
            var data =  await _httpClient.GetFromJsonAsync<List<SuperHero>>("api/superheros");
            return data;
        }
    }
}
