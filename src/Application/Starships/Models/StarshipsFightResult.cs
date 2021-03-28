using StarCardWars.Domain.Entities;

namespace StarCardWars.Application.Starships.Models
{
    public class StarshipsFightResult
    {
        public StarshipDto FirstPlayeStarship { get; set; }
        public StarshipDto SecondPlayeStarship { get; set; }
        public string FightProperty { get; set; }
        public int FirstPlayerOverallScore { get; set; }
        public int SecondPlayerOverallScore { get; set; }
        public bool IsDraw { get; set; }
    }
}
