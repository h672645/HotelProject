using System;
using System.Collections.Generic;

namespace HotelClasses.NET.YourOutputDirectory;

public partial class HotelRoom
{
    public int RoomId { get; set; }

    public int? NumberOfBeds { get; set; }

    public int? SizeOfRoom { get; set; }

    public string? QualityOfRoom { get; set; }

    public bool? Occupied { get; set; }

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();

    public override string ToString()
    {
        return RoomId.ToString();
    }

    public bool IsReservationActive(DateTime currentDate, DateTime StartDate, DateTime EndDate)
    {
        if (this == null)
        {
            return false;
        }

        if (currentDate >= StartDate && currentDate < EndDate)
        {
            this.Occupied = true;
            return true;
        }

        this.Occupied = false;
        return false;
    }
}
