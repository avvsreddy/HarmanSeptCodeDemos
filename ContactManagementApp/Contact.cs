using System;
using System.Collections.Generic;

namespace ContactManagementApp;

public partial class Contact
{
    public int Id { get; set; }

    public string ContactName { get; set; } = null!;

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }
}
