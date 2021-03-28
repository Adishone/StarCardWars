using MediatR;
using Microsoft.EntityFrameworkCore;
using StarCardWars.Application.Common.Interfaces;
using StarCardWars.Domain.Entities;
using StarCardWars.Domain.Enums;
using System.Threading;
using System.Threading.Tasks;

namespace StarCardWars.Application.Scores.Commands
{
    public class UpdateScoreCommand : IRequest<Score>
    {
        public PlayerEnum WinningPlayer {get; set;}
        public UpdateScoreCommand(PlayerEnum winnningPlayer)
        {
            WinningPlayer = winnningPlayer;
        }
    }

    public class UpdateScoreCommandHandler : IRequestHandler<UpdateScoreCommand, Score>
    {
        private readonly IApplicationDbContext _context;

        public UpdateScoreCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Score> Handle(UpdateScoreCommand request, CancellationToken cancellationToken)
        {
            var score = await _context.Scores.FirstOrDefaultAsync();

            if (request.WinningPlayer == PlayerEnum.FirstPlayer)
            {
                score.FirstPlayerWins++;
            }
            else
            {
                score.SecondPlayerWins++;
            }

            await _context.SaveChangesAsync(cancellationToken);

            return score;
        }
    }
}
