using StarCardWars.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace StarCardWars.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<CrewMember> CrewMembers { get; set; }

        DbSet<Starship> Starships { get; set; }
        DbSet<Score> Scores { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
