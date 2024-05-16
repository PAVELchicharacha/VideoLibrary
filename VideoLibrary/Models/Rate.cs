using System;
using System.Collections.Generic;

namespace VideoLibrary.Models;

public partial class Rate
{
    public int IdRate { get; set; }

    public string? RateName { get; set; }

    public decimal? RateCoastPerMonth { get; set; }

    public int? NumbersOfFilms { get; set; }
}
