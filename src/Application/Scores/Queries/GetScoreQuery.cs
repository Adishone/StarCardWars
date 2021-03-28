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
    public class GetScoreQuery : IRequest<Score>
    {
        public string FightProperty { get; set; }
    }

    public class GetScoreQueryHandler : IRequestHandler<GetScoreQuery, Score>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetScoreQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Score> Handle(GetScoreQuery request, CancellationToken cancellationToken)
        {
            return await _context.Scores.FirstOrDefaultAsync();
        }
    }
}
