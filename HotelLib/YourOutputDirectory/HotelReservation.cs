using System;
using System.Collections.Generic;

namespace HotelClasses.NET.YourOutputDirectory;

public partial class HotelReservation
{
    public int ReservationId { get; set; }

    public int GuestId { get; set; }

    public int? RoomId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Guest Guest { get; set; } = null!;

    public virtual HotelRoom? Room { get; set; }
}
