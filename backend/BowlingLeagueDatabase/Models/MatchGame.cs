using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BowlingLeagueDatabase.Models;

public partial class MatchGame
{
    [Key]
    public int MatchId { get; set; }

    public short GameNumber { get; set; }

    public int? WinningTeamId { get; set; }

    public virtual TourneyMatch Match { get; set; } = null!;
}
