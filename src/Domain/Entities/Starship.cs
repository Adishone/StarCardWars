using System.Collections.Generic;

namespace StarCardWars.Domain.Entities
{
    public class Starship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public string ImagePath { get; set; }
        public virtual List<CrewMember> CrewMembers { get; set; }
    }
}
