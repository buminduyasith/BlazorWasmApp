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
        public async Task<List<SuperHeroVM>> GetAllSuperHeros()
        {
            var data =  await _httpClient.GetFromJsonAsync<List<SuperHeroVM>>("api/superheros");
            return data;
        }
    }
}
