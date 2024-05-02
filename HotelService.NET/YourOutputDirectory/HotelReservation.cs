using System;
using System.Collections.Generic;

namespace HotelService.NET.YourOutputDirectory;

public partial class HotelReservation
{
    public int ReservationId { get; set; }

    public int? GuestId { get; set; }

    public int? RoomId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Guest? Guest { get; set; }

    public virtual HotelRoom? Room { get; set; }
}
