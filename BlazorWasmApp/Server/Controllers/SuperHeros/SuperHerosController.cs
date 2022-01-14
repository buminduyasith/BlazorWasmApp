using Core.SuperHeros.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmApp.Server.Controllers
{
    public class SuperHerosController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllSuperHeros()
        {
            var query = new GetAllSuperHeroQuery();
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
