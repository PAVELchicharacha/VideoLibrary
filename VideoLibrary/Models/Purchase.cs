using System;
using System.Collections.Generic;

namespace VideoLibrary.Models;

public partial class Purchase
{
    public int IdPurchase { get; set; }

    public int? IdUser { get; set; }

    public int? IdFilm { get; set; }

    public int? IdRate { get; set; }

    public double? PurchaseCoast { get; set; }
}
