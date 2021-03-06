using Core.Common.Interfaces;
using BlazorWasmApp.Shared;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SuperHeros.Queries
{
    public class GetAllSuperHeroQuery:IRequest<List<SuperHeroVM>>
    {
    }
    public class GetAllSuperHeroQueryHanlder : IRequestHandler<GetAllSuperHeroQuery, List<SuperHeroVM>>
    {
        private readonly ISuperHeroService _superHeroService;
        private readonly ILogger _logger;
        public GetAllSuperHeroQueryHanlder(ISuperHeroService superHeroService, ILogger<GetAllSuperHeroQueryHanlder> logger)
        {
            _superHeroService = superHeroService;
            _logger = logger;
        }
        public  Task<List<SuperHeroVM>> Handle(GetAllSuperHeroQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_superHeroService.GetAllSuperHeroes());
        }
    }
}
