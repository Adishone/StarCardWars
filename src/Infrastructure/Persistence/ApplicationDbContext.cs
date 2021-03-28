using StarCardWars.Application.Common.Interfaces;
using StarCardWars.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace StarCardWars.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IDateTime _dateTime;

        public ApplicationDbContext(
            DbContextOptions options,
            IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<CrewMember> CrewMembers { get; set; }

        public DbSet<Starship> Starships { get; set; }

        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
