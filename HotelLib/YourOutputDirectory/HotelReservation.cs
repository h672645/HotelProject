using System;
using System.Collections.Generic;

namespace HotelClasses.NET.YourOutputDirectory;

public partial class HotelReservation
{
    public int ReservationId { get; set; }

    public int? GuestId { get; set; }

    public int? RoomId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual Guest? Guest { get; set; }

    public virtual HotelRoom? Room { get; set; }
}
