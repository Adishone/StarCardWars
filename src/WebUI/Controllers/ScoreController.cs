using Microsoft.AspNetCore.Mvc;
using StarCardWars.Application.CrewMembers.Queries;
using StarCardWars.Domain.Entities;
using System.Threading.Tasks;

namespace StarCardWars.WebUI.Controllers
{
    public class ScoreController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Score>> GetScore()
        {
            return await Mediator.Send(new GetScoreQuery());
        }
    }
}
