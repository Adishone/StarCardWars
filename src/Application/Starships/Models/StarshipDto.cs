using AutoMapper;
using StarCardWars.Application.Common.Mappings;
using StarCardWars.Domain.Entities;
using System.Collections.Generic;

namespace StarCardWars.Application.Starships.Models
{
    public class StarshipDto : IMapFrom<Starship>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public string ImagePath { get; set; }
        public virtual List<CrewMember> CrewMembers { get; set; }
        public bool IsWinner { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Starship, StarshipDto>()
                .ForMember(cm => cm.IsWinner, opt => opt.Ignore());
        }
    }
}
