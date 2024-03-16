namespace BowlingLeagueDatabase.Models
{
    public interface IBowlingLeagueRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
