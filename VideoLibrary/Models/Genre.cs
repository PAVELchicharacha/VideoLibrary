using System;
using System.Collections.Generic;

namespace VideoLibrary.Models;

public partial class Genre
{
    public int IdGenre { get; set; }

    public string? GenreName { get; set; }

    public string? Description { get; set; }
}
