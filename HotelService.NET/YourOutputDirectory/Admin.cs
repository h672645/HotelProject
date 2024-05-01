using System;
using System.Collections.Generic;

namespace HotelService.NET.YourOutputDirectory;

public partial class Admin
{
    public int AdminId { get; set; }

    public virtual Person AdminNavigation { get; set; } = null!;
}
