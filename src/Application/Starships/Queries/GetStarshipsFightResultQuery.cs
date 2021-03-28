using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StarCardWars.Application.Common.Interfaces;
using StarCardWars.Application.CrewMembers.Models;
using StarCardWars.Application.Scores.Commands;
using StarCardWars.Application.Starships.Models;
using StarCardWars.Domain.Entities;
using StarCardWars.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StarCardWars.Application.CrewMembers.Queries
{
    public class GetStarshipsFightResultQuery : IRequest<StarshipsFightResult>
    {
        public string FightProperty { get; set; }
    }

    public class GetStarshipsFightResultQueryHandler : IRequestHandler<GetStarshipsFightResultQuery, StarshipsFightResult>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ISender _mediator;

        public GetStarshipsFightResultQueryHandler(IApplicationDbContext context, IMapper mapper, ISender mediator)
        {
            _context = context;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<StarshipsFightResult> Handle(GetStarshipsFightResultQuery request, CancellationToken cancellationToken)
        {
            List<Starship> starships = await _context.Starships.Include(s => s.CrewMembers)
                                                               .OrderBy(r => Guid.NewGuid()).Take(2).ToListAsync();
            var fightResult = new StarshipsFightResult();
            fightResult.FightProperty = request.FightProperty;
            fightResult.FirstPlayeStarship = _mapper.Map<StarshipDto>(starships.First()); 
            fightResult.SecondPlayeStarship = _mapper.Map<StarshipDto>(starships.Last());
            Score score;
            var firstStarshipProperty = request.FightProperty == "Mass" ? fightResult.FirstPlayeStarship.Mass : fightResult.FirstPlayeStarship.NumberOfCrewMembers;
            var secondStarshipProperty = request.FightProperty == "Mass" ? fightResult.SecondPlayeStarship.Mass : fightResult.SecondPlayeStarship.NumberOfCrewMembers;

            if (firstStarshipProperty == secondStarshipProperty)
            {
                fightResult.IsDraw = true;
                score = await _mediator.Send(new GetScoreQuery());
            }
            else if (firstStarshipProperty > secondStarshipProperty)
            {
                fightResult.FirstPlayeStarship.IsWinner = true;
                score = await _mediator.Send(new UpdateScoreCommand(PlayerEnum.FirstPlayer));                
            }
            else
            {
                fightResult.SecondPlayeStarship.IsWinner = true;
                score = await _mediator.Send(new UpdateScoreCommand(PlayerEnum.SecondPlayer));
            }

            fightResult.FirstPlayerOverallScore = score.FirstPlayerWins;
            fightResult.SecondPlayerOverallScore = score.SecondPlayerWins;

            return fightResult;
        }
    }
}
