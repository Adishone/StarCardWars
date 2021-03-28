using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StarCardWars.Application.Common.Interfaces;
using StarCardWars.Application.CrewMembers.Models;
using StarCardWars.Application.Scores.Commands;
using StarCardWars.Domain.Entities;
using StarCardWars.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StarCardWars.Application.CrewMembers.Queries
{
    public class GetCrewMembersFightResultQuery : IRequest<CrewMembersFightResult>
    {
        public string FightProperty { get; set; }
    }

    public class GetCrewMembersFightResultQueryHandler : IRequestHandler<GetCrewMembersFightResultQuery, CrewMembersFightResult>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ISender _mediator;

        public GetCrewMembersFightResultQueryHandler(IApplicationDbContext context, IMapper mapper, ISender mediator)
        {
            _context = context;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<CrewMembersFightResult> Handle(GetCrewMembersFightResultQuery request, CancellationToken cancellationToken)
        {
            List<CrewMember> crewMembers = await _context.CrewMembers.OrderBy(r => Guid.NewGuid()).Take(2).ToListAsync();
            var fightResult = new CrewMembersFightResult();
            fightResult.FightProperty = request.FightProperty;
            fightResult.FirstPlayerCrewMember = _mapper.Map<CrewMemberDto>(crewMembers.First()); 
            fightResult.SecondPlayerCrewMember = _mapper.Map<CrewMemberDto>(crewMembers.Last());
            var firstCrewMemberProperty = (int)typeof(CrewMemberDto).GetProperty(request.FightProperty).GetValue(fightResult.FirstPlayerCrewMember);
            var secondCrewMemberProperty = (int)typeof(CrewMemberDto).GetProperty(request.FightProperty).GetValue(fightResult.SecondPlayerCrewMember);
            Score score;
            
            if (firstCrewMemberProperty == secondCrewMemberProperty)
            {
                fightResult.IsDraw = true;
                score = await _mediator.Send(new GetScoreQuery());
            }
            else if (firstCrewMemberProperty > secondCrewMemberProperty)
            {
                fightResult.FirstPlayerCrewMember.IsWinner = true;
                score = await _mediator.Send(new UpdateScoreCommand(PlayerEnum.FirstPlayer));                
            }
            else
            {
                fightResult.SecondPlayerCrewMember.IsWinner = true;
                score = await _mediator.Send(new UpdateScoreCommand(PlayerEnum.SecondPlayer));
            }

            fightResult.FirstPlayerOverallScore = score.FirstPlayerWins;
            fightResult.SecondPlayerOverallScore = score.SecondPlayerWins;

            return fightResult;
        }
    }
}
