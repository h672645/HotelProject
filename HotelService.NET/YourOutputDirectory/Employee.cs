using System;
using System.Collections.Generic;

namespace HotelService.NET.YourOutputDirectory;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Stilling { get; set; }

    public virtual Person EmployeeNavigation { get; set; } = null!;
}
