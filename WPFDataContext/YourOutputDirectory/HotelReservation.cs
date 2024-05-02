using System;
using System.Collections.Generic;

namespace WPFDataContext.YourOutputDirectory;

public partial class HotelReservation
{
    public int ReservationId { get; set; }

    public required int GuestId { get; set; }

    public int? RoomId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Guest? Guest { get; set; }

    public virtual HotelRoom? Room { get; set; }

    public override string ToString()
    {
        return $"ReservationNr:{ReservationId} Guest:{GuestId} Room:{RoomId}";
    }
}
