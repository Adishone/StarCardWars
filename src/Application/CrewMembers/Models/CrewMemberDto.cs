using AutoMapper;
using StarCardWars.Application.Common.Mappings;
using StarCardWars.Domain.Entities;

namespace StarCardWars.Application.CrewMembers.Models
{
    public class CrewMemberDto : IMapFrom<CrewMember>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intellect { get; set; }
        public int StarshipId { get; set; }
        public string ImagePath { get; set; }
        public virtual Starship Starship { get; set; }
        public bool IsWinner { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CrewMember, CrewMemberDto>()
                .ForMember(cm => cm.IsWinner, opt => opt.Ignore());
        }
    }
}
