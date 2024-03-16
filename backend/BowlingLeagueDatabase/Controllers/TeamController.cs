using BowlingLeagueDatabase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingLeagueDatabase.Controllers
{
    // Controller for the teams
    [Route("[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private IBowlingLeagueRepository _bowlingRepository;
        public TeamController(IBowlingLeagueRepository context)
        {
            _bowlingRepository = context;
        }

        [HttpGet]
        public IEnumerable<Team> Get()
        {
            var teamData = _bowlingRepository.Teams.ToArray();

            return teamData;
        }
    }
}