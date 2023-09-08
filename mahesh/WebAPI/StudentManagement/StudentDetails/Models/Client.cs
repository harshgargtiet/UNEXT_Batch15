using System;
using System.Collections.Generic;

namespace StudentDetails.Models;

public partial class Client
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Role { get; set; }
}
