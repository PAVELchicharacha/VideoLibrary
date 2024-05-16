using System;
using System.Collections.Generic;

namespace VideoLibrary.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PaymentMethod { get; set; }

    public bool? Subscription { get; set; }

    public int? IdRate { get; set; }
}
