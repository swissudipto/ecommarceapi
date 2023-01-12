using System;
using System.Collections.Generic;

namespace ecommarceapi.Models;

public partial class UserCred
{
    public decimal Userid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
