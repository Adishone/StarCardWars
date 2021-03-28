namespace StarCardWars.Domain.Entities
{
    public class CrewMember
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
    }
}
