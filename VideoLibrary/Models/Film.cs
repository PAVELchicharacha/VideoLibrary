using System;
using System.Collections.Generic;

namespace VideoLibrary.Models;

public partial class Film
{
    public int IdFilm { get; set; }

    public string? Name { get; set; }

    public string? Genre { get; set; }

    public DateOnly? YearOfIssue { get; set; }

    public string? Director { get; set; }

    public string? MainActor { get; set; }

    public double? UserRate { get; set; }

    public int? IdRate { get; set; }

    public decimal? FilmCoast { get; set; }
}
