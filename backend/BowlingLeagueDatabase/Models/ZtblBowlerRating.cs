using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BowlingLeagueDatabase.Models;

public partial class ZtblBowlerRating
{
    public string BowlerRating { get; set; } = null!;

    public short? BowlerLowAvg { get; set; }

    public short? BowlerHighAvg { get; set; }
}
