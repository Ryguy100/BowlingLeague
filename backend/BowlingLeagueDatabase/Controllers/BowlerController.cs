using BowlingLeagueDatabase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingLeagueDatabase.Controllers
{
    // Controller for the bowlers
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingLeagueRepository _bowlingRepository;
        public BowlerController(IBowlingLeagueRepository context)
        {
            _bowlingRepository = context;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            // Filters and gets data for the bowlers
            var bowlerData = _bowlingRepository.Bowlers
                .Where(x => x.TeamId == 1 || x.TeamId == 2)
                .ToArray();

            return bowlerData;
        }
    }
}
