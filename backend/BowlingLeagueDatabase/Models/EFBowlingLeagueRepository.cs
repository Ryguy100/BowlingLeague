namespace BowlingLeagueDatabase.Models
{
    public class EFBowlingLeagueRepository : IBowlingLeagueRepository
    {
        private BowlingLeagueContext _bowlingContext;

        public EFBowlingLeagueRepository(BowlingLeagueContext context)
        {
            _bowlingContext = context;
        }

        // List the tables that will be using
        public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;
        public IEnumerable<Team> Teams => _bowlingContext.Teams;
    }
}
