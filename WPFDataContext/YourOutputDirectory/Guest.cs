using System;
using System.Collections.Generic;

namespace WPFDataContext.YourOutputDirectory;

public partial class Guest
{
    public int GuestId { get; set; }

    public virtual Person GuestNavigation { get; set; } = null!;

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();
    public override string ToString()
    {
        // Call the parent class's ToString() method
        return GuestNavigation.ToString();
    }
}
