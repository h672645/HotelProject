using System;
using System.Collections.Generic;

namespace WPFDataContext.YourOutputDirectory;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Stilling { get; set; }

    public virtual Person EmployeeNavigation { get; set; } = null!;
}
