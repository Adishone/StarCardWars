using StarCardWars.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarCardWars.Infrastructure.Persistence.Configurations
{
    public class CrewMemberConfiguration : IEntityTypeConfiguration<CrewMember>
    {
        public void Configure(EntityTypeBuilder<CrewMember> builder)
        {
        }
    }
}