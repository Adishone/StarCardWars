using StarCardWars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCardWars.Application.CrewMembers.Models
{
    public class CrewMembersFightResult
    {
        public CrewMemberDto FirstPlayerCrewMember { get; set; }
        public CrewMemberDto SecondPlayerCrewMember { get; set; }
        public string FightProperty { get; set; }
        public int FirstPlayerOverallScore { get; set; }
        public int SecondPlayerOverallScore { get; set; }
        public bool IsDraw { get; set; }
    }
}
