using AutoMapper;
using StarCardWars.Application.Common.Mappings;
using StarCardWars.Application.CrewMembers.Models;
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
        public bool IsWinner { get; set; }
        public int NumberOfCrewMembers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Starship, StarshipDto>()
                .ForMember(cm => cm.IsWinner, opt => opt.Ignore())
                .ForMember(cm => cm.NumberOfCrewMembers, opt => opt.MapFrom(src => src.CrewMembers.Count));
        }
    }
}
