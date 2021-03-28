using Microsoft.AspNetCore.Mvc;
using StarCardWars.Application.CrewMembers.Queries;
using StarCardWars.Application.Starships.Models;
using System.Threading.Tasks;

namespace StarCardWars.WebUI.Controllers
{
    public class StarshipFightController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<StarshipsFightResult>> GetStarshipFightResult([FromQuery] GetStarshipsFightResultQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
