using MediatR;
using Microsoft.AspNetCore.Mvc;
using StarCardWars.Application.CrewMembers.Models;
using StarCardWars.Application.CrewMembers.Queries;
using System.Threading.Tasks;

namespace StarCardWars.WebUI.Controllers
{
    public class CrewMemberFightController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<CrewMembersFightResult>> GetCrewMembersFightResult([FromQuery] string fightProperty)
        {
            return await Mediator.Send(new GetCrewMembersFightResultQuery(fightProperty));
        }
    }
}
