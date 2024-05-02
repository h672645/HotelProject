using System;
using System.Collections.Generic;

namespace WPFDataContext.YourOutputDirectory;

public partial class Admin
{
    public int AdminId { get; set; }

    public virtual Person AdminNavigation { get; set; } = null!;

    public override string ToString()
    {
        // Call the parent class's ToString() method
        return AdminNavigation.ToString();
    }
}
