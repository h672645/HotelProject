using System;
using System.Collections.Generic;

namespace HotelService.NET.YourOutputDirectory;

public partial class Guest
{
    public int GuestId { get; set; }

    public virtual Person GuestNavigation { get; set; } = null!;

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();
}
