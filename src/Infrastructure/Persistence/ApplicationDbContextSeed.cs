using StarCardWars.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StarCardWars.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedStarshipsAsync(ApplicationDbContext context)
        {
            if (!context.Starships.Any())
            {
                var rand = new Random();
                context.Starships.Add(new Starship
                {
                    Id = 1,
                    Mass = rand.NextDouble() * 100,
                    Name = "Stellar Spirit",
                    ImagePath = "https://cdn.pixabay.com/photo/2014/09/11/12/45/spacecraft-441708_960_720.jpg",
                });
                context.Starships.Add(new Starship
                {
                    Id = 2,
                    Mass = rand.NextDouble() * 100,
                    Name = "Archimedes",
                    ImagePath = "https://cdn.pixabay.com/photo/2017/02/11/10/33/spaceship-2057420_960_720.jpg",
                });
                context.Starships.Add(new Starship
                {
                    Id = 3,
                    Mass = rand.NextDouble() * 100,
                    Name = "Vengeance",
                    ImagePath = "https://cdn.pixabay.com/photo/2017/02/11/10/33/spaceship-2057420_960_720.jpg",
                });
                context.Starships.Add(new Starship
                {
                    Id = 4,
                    Mass = rand.NextDouble() * 100,
                    Name = "Spirit of Inquiry",
                    ImagePath = "https://cdn.pixabay.com/photo/2017/06/23/09/16/composing-2434042_960_720.jpg",
                });

                await context.SaveChangesAsync();
            }
        }

        public static async Task SeedCrewMembersAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.CrewMembers.Any())
            {
                var rand = new Random();
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 1,
                    FirstName = "Jethro",
                    LastName = "Chung",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 1,
                    ImagePath = "https://randomuser.me/api/portraits/men/1.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 2,
                    FirstName = "Dillan",
                    LastName = "Duke",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 1,
                    ImagePath = "https://randomuser.me/api/portraits/men/2.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 3,
                    FirstName = "Santiago",
                    LastName = "Burrows",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 2,
                    ImagePath = "https://randomuser.me/api/portraits/men/3.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 4,
                    FirstName = "Musa",
                    LastName = "Levine",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 2,
                    ImagePath = "https://randomuser.me/api/portraits/women/1.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 5,
                    FirstName = "Aahil",
                    LastName = "Rowland",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 3,
                    ImagePath = "https://randomuser.me/api/portraits/women/2.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 6,
                    FirstName = "Zakariyah",
                    LastName = "Coulson",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 3,
                    ImagePath = "https://randomuser.me/api/portraits/men/4.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 7,
                    FirstName = "Domonic",
                    LastName = "French",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 3,
                    ImagePath = "https://randomuser.me/api/portraits/men/5.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 8,
                    FirstName = "Andre",
                    LastName = "Burn",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 4,
                    ImagePath = "https://randomuser.me/api/portraits/men/6.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 9,
                    FirstName = "Sienna",
                    LastName = "Melendez",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 4,
                    ImagePath = "https://randomuser.me/api/portraits/women/3.jpg"
                });
                context.CrewMembers.Add(new CrewMember
                {
                    Id = 10,
                    FirstName = "Halima",
                    LastName = "Hatfield",
                    Strength = rand.Next(1, 10),
                    Agility = rand.Next(1, 10),
                    Intellect = rand.Next(1, 10),
                    StarshipId = 4,
                    ImagePath = "https://randomuser.me/api/portraits/women/4.jpg"
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
